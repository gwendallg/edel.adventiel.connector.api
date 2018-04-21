using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMongoDatabase _database;
        private readonly IMapper _mapper;
        

        public CollectorService(IMongoClient client, IMapper mapper)
        {
            _database = client.GetDatabase("EDEL");
            _mapper = mapper;
        }


        private Dictionary<Type, List<object>> Map(MessageMdBDonneesGenetiquesAnimales donneesGenetiquesAnimales)
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


        public async Task CollectAsync(string userId)
        {
           Subscription subscription = null;
            try
            {
                var department = await FindDepartementAsync(userId);

                subscription = await _database
                    .GetCollection<Subscription>("subscription")
                    .Find(s => s.UserId == userId && s.Active)
                    .SingleOrDefaultAsync();
                if (subscription == null) return;
/*
               
               var data = await GetDatasAsync(
                    subscription.UserId,
                    department,
                    subscription.Password.Decrypt(),
                    subscription.LastCollectTime ?? DateTime.Now.AddMonths(-3),
                    DateTime.Now);

                await PopulateBreederAsync(data);
                await PopulateCattleAsync(data);*/
                }
            catch (Exception e)
            {
                if (subscription == null) throw;
                subscription.LastMessage = e.Message;
                await _database
                    .GetCollection<Subscription>("subscription")
                    .ReplaceOneAsync(s => s.UserId == subscription.UserId, subscription);
            }
        }

        private async Task PopulateBreederAsync(MdBGetDonneesGenetiquesAnimalesResponse response)
        {

            var breederCollection = _database.GetCollection<Breeder>("breeder");
            var exploitation = response.ReponseSpecifique.MdBDonneesGenetiquesAnimales.InformationsMessage.Exploitation;

            var breeder = await breederCollection.Find(b =>
                b.BreederCountryCode == exploitation.CodePaysExploitation.ToString() &&
                b.BreederIdentifier == exploitation.NumeroExploitation.Trim())
            .SingleOrDefaultAsync();

            if (breeder == null)
            {
                breeder = _mapper.Map<Breeder>(exploitation);
                breeder.Metadata = new Metadata()
                {
                    CreatedAt = "admin",
                    CreatedDate = DateTime.UtcNow
                };
                await breederCollection.InsertOneAsync(breeder);
            }
            else
            {
                _mapper.Map(exploitation, breeder);
                breeder.Metadata.LastModifiedAt = "admin";
                breeder.Metadata.LastModifiedDate = DateTime.UtcNow;
                await breederCollection.ReplaceOneAsync(b => b.Id == breeder.Id, breeder);

            }
        }

        private async Task PopulateCattleAsync(MdBGetDonneesGenetiquesAnimalesResponse response)
        {
            var cattleCollection = _database.GetCollection<CattleBreeder>("cattle");
            var exploitation = response.ReponseSpecifique.MdBDonneesGenetiquesAnimales.InformationsMessage.Exploitation;

            foreach (var bovin in response.ReponseSpecifique.MdBDonneesGenetiquesAnimales.Bovin)
            {
                var cattle = await cattleCollection.Find(b =>
                        b.BreederCountryCode == exploitation.CodePaysExploitation.ToString() &&
                        b.BreederIdentifier == exploitation.NumeroExploitation.Trim() &&
                        b.CattleCountryCode == bovin.CodePays.ToString() &&
                        b.CattleIdentifier == bovin.NumeroNationalAnimal.Trim())
                    .SingleOrDefaultAsync();

                if (cattle == null)
                {
                    cattle = _mapper.Map<CattleBreeder>(bovin);
                    cattle.BreederCountryCode = exploitation.CodePaysExploitation.ToString();
                    cattle.BreederIdentifier = exploitation.NumeroExploitation.Trim();
                    cattle.Metadata = new Metadata()
                    {
                        CreatedAt = "admin",
                        CreatedDate = DateTime.UtcNow
                    };
                    await cattleCollection.InsertOneAsync(cattle);
                }
                else
                {
                    _mapper.Map(bovin, cattle);
                    cattle.Metadata.LastModifiedAt = "admin";
                    cattle.Metadata.LastModifiedDate = DateTime.UtcNow;
                    await cattleCollection.ReplaceOneAsync(b => b.Id == cattle.Id, cattle);
                }
            }
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
 
        static async Task<tkGetUrlResponse> GetUrlResponse(string entreprise)
        {
            var client = CreateClient<WsAnnuaireClient>("http://wstest1-directory.fiea.fr/wsannuaire/WsAnnuaire");
            var request = new tkGetUrlRequest
            {
                VersionPK = new typeVersionPK
                {
                    CodeSiteVersion = "9",
                    CodeSiteService = "9",
                    NumeroVersion = "5.06",
                    NomService = "MdBEdel"
                },
                ProfilDemandeur = new typeProfil {Entreprise = entreprise}
            };
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

        private static async Task<tkCreateIdentificationResponse> CreateIdentificationResponse(string userId,
            string password, string entreprise,
            string uri)
        {
            var client = CreateClient<WsGuichetClient>(uri);
            var request = new tkCreateIdentificationRequest
            {
                Identification = new typeIdentification
                {
                    UserId = userId,
                    Password = password,
                    Profil = new WsGuichets.typeProfil {Entreprise = entreprise}
                }
            };
            return await client.tkCreateIdentificationAsync(request);
        }

        private static async Task<MdBGetDonneesGenetiquesAnimalesResponse> GetDonneesGenetiquesAnimalesResponse(string jeton, string userd, string uri, DateTime startingDate, DateTime? endingDate = null)
        {
            var client = CreateClient<wsMdBInterfaceClient>(uri);
            var request = new MdBGetDonneesGenetiquesAnimalesRequest
            {
                DateDebutDemande = startingDate,
                DateFinDemande = endingDate ?? DateTime.Now,
                Exploitation = new typeIdentifiantExploitation
                {
                    CodePaysExploitation = TypeCodePays.FR,
                    NumeroExploitation = userd
                },
                JetonAuthentification = jeton
            };

            return await client.MdBGetDonneesGenetiquesAnimalesAsync(request);
        } 
    }
}