using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Edel.Adventiel.Connector.Entities;
using Edel.Adventiel.Connector.Entities.Breeders;
using Edel.Adventiel.Connector.Entities.Cattles;
using Edel.Adventiel.Connector.Entities.References;
using MongoDB.Driver;
using WsAnnuaires;
using WsGuichets;
using WsMdBInterfaces;
using typeProfil = WsAnnuaires.typeProfil;
using typeVersionPK = WsAnnuaires.typeVersionPK;

namespace Edel.Adventiel.Connector.Services
{
    public class CollectorService : ICollectorService
    {
        private static readonly IMapper _mapper;
        private readonly IMongoDatabase _database;
     
        static CollectorService()
        {
            var baseMappings = new MapperConfigurationExpression();

            baseMappings.CreateMap<typeIdentifiantExploitation, Breeder>()
                .ForMember(dest => dest.BreederCountryCode, opt => opt.MapFrom(src => src.CodePaysExploitation))
                .ForMember(dest => dest.BreederIdentifier, opt => opt.MapFrom(src => src.NumeroExploitation));
            
            baseMappings.CreateMap<Identite, CattleIdentity>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DateNaissance))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nom))
                .ForMember(dest => dest.BreedCode, opt => opt.MapFrom(src => src.CodeRaceBovin))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sexe));

            baseMappings.CreateMap<Bovin, Cattle>()
                .ForMember(dest => dest.CattleCountryCode, opt => opt.MapFrom(src => src.CodePays))
                .ForMember(dest => dest.CattleIdentifier, opt => opt.MapFrom(src => src.NumeroNationalAnimal));
            
                    
            var mapperConfiguration = new MapperConfiguration(baseMappings);
            _mapper = new Mapper(mapperConfiguration);
        }

        public CollectorService(IMongoDatabase database)
        {
            _database = database;
        }


        private static Dictionary<Type, List<object>> Map(MessageMdBDonneesGenetiquesAnimales donneesGenetiquesAnimales)
        {
            var result = new Dictionary<Type, List<object>>();

            #region breeder
            
            var breeder =
                _mapper.Map<typeIdentifiantExploitation, Breeder>(donneesGenetiquesAnimales.InformationsMessage
                    .Exploitation);

            result.Add(typeof(Breeder), new List<object>(new[] {breeder}));
            
            #endregion

            return result;

        }


        public async Task<string> CollectAsync(int size = 10, string collectorAt = "admin")
        {
            var subscriptions = await _database
                .GetCollection<Subscription>("edelSubscription")
                .Find(c => true)
                .Sort(Builders<Subscription>.Sort.Descending(x => x.LastCollectTime))
                .Limit(size)
                .ToListAsync();

            foreach (var subscription in subscriptions)
            {
                try
                {
                    var department = await FindDepartementAsync(subscription.UserId);
                    var password = subscription.Password.Decrypt();
                    var data = await GetDatasAsync(
                        subscription.UserId,
                        department,
                        subscription.Password.Decrypt(),
                        subscription.LastCollectTime ?? DateTime.Now.AddMonths(-3),
                        DateTime.Now);
                }
                catch (Exception e)
                {
                    subscription.LastMessage = e.Message;
                    await _database
                        .GetCollection<Subscription>("edelSubscription")
                        .ReplaceOneAsync(s => s.UserId == subscription.UserId, subscription);
                }
            }

            return "OK";
        }


        /// <summary>
        /// recherche le département de rattachement de l'exploitation
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private async Task<Department> FindDepartementAsync(string userId)
        {
            var departementId = userId.Substring(0, 2);
            return await _database
                .GetCollection<Department>("department")
                .Find(d => d.Id == departementId)
                .SingleOrDefaultAsync();
        }

        static async Task<MdBGetDonneesGenetiquesAnimalesResponse> GetDatasAsync(string userId, Department departement, string password,
            DateTime startingDate, DateTime? endingDate = null)
        {
            var urlResponse = await GetUrlResponse(departement.Enterprise);
            if (urlResponse.ReponseStandard.Anomalie != null)
                throw new Exception(urlResponse.ReponseStandard.Anomalie.Message);

            var identificationResponse = await CreateIdentificationResponse(userId, password, departement.Enterprise,
                urlResponse.ReponseSpecifique.InfosServiceMetierRegional.UrlGuichet);
            if (identificationResponse.ReponseStandard.Anomalie != null)
                throw new Exception(identificationResponse.ReponseStandard.Anomalie.Message);

            var mdBGetDonneesGenetiquesAnimalesResponse = await GetDonneesGenetiquesAnimalesResponse(
                identificationResponse.Jeton,
                userId,
                urlResponse.ReponseSpecifique.InfosServiceMetierRegional.UrlMetier,
                startingDate,
                endingDate
            );
            if (mdBGetDonneesGenetiquesAnimalesResponse.ReponseStandard.Anomalie != null)
                throw new Exception(mdBGetDonneesGenetiquesAnimalesResponse.ReponseStandard.Anomalie.Message);
            return mdBGetDonneesGenetiquesAnimalesResponse;
        }

        static async Task<string> GetEntreprise(string userId)
        {
            return "E220";
        }
        
        static async Task<tkGetUrlResponse> GetUrlResponse(string entreprise)
        {
            var client = CreateClient<WsAnnuaireClient>("http://wstest1-directory.fiea.fr/wsannuaire/WsAnnuaire");
            var request = new tkGetUrlRequest();
            request.VersionPK = new typeVersionPK();
            request.VersionPK.CodeSiteVersion = "9";
            request.VersionPK.CodeSiteService = "9";
            request.VersionPK.NumeroVersion = "5.06";
            request.VersionPK.NomService = "MdBEdel";
            request.ProfilDemandeur = new typeProfil();
            request.ProfilDemandeur.Entreprise = entreprise;
            return await client.tkGetUrlAsync(request);
        }

        private static T CreateClient<T>(string uri) 
        {
            var constructor = typeof(T).GetConstructor(new[] {typeof(Binding), typeof(EndpointAddress)});
            var remoteAddress = new EndpointAddress(uri);
            HttpBindingBase binding;
            if (uri.ToLowerInvariant().StartsWith("https://"))
            {
                binding = new BasicHttpsBinding();
                ((BasicHttpsBinding) binding).Security.Mode = BasicHttpsSecurityMode.Transport;

            }
            else
            {
                binding = new BasicHttpBinding();

            }

            binding.Name = "WebWorkerSoap";
            binding.CloseTimeout = TimeSpan.FromMinutes(1);
            binding.OpenTimeout = TimeSpan.FromMinutes(1);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(10);
            binding.SendTimeout = TimeSpan.FromMinutes(1);
            binding.MaxReceivedMessageSize = 2147483647;
            return (T) constructor.Invoke(new object[] {binding, remoteAddress});
        }

        private static async Task<tkCreateIdentificationResponse> CreateIdentificationResponse(string userId, string password, string entreprise,
            string uri)
        {
            var client = CreateClient<WsGuichetClient>(uri);
            var request = new tkCreateIdentificationRequest();
            request.Identification = new typeIdentification();
            request.Identification.UserId = userId;
            request.Identification.Password = password;
            request.Identification.Profil = new WsGuichets.typeProfil();
            request.Identification.Profil.Entreprise = entreprise;
            return await client.tkCreateIdentificationAsync(request);
        }

        private static async Task<MdBGetDonneesGenetiquesAnimalesResponse> GetDonneesGenetiquesAnimalesResponse(string jeton, string userd, string uri, DateTime startingDate, DateTime? endingDate = null)
        {
            var client = CreateClient<wsMdBInterfaceClient>(uri);
            var request = new MdBGetDonneesGenetiquesAnimalesRequest();
            request.DateDebutDemande = startingDate;
            request.DateFinDemande = endingDate ?? DateTime.Now;
            request.Exploitation= new typeIdentifiantExploitation();
            request.Exploitation.CodePaysExploitation =  TypeCodePays.FR;
            request.Exploitation.NumeroExploitation = userd;
            request.JetonAuthentification = jeton;

            return await client.MdBGetDonneesGenetiquesAnimalesAsync(request);
        } 
    }
}