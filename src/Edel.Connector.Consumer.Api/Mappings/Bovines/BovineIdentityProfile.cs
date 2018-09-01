
using AutoMapper;
using Edel.Connector.Models.Bovines;
using WsMdBInterfaces;

namespace Edel.Connector.Consumer.Api.Mappings.Cattles
{
    /// <inheritdoc />
    public class BovineIdentityProfile : Profile
    {
        public BovineIdentityProfile()
        {
            CreateMap<Identite, BovineIdentity>()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.DateNaissance))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nom.Trim()))
                .ForMember(dest => dest.BreedCode, opt => opt.MapFrom(src => src.CodeRaceBovin))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sexe));
        }
    }
}