
using AutoMapper;
using Edel.Connector.Models.Bovines;
using WsMdBInterfaces;

namespace Edel.Connector.Consumer.Api.Mappings.Bovines
{
    public class BovineProfile  : Profile
    {
        public BovineProfile()
        {
            CreateMap<Bovin, Bovine>()
                .ForMember(dest => dest.BovineCountryCode, opt => opt.MapFrom(src => src.CodePays))
                .ForMember(dest => dest.BovineIdentifier, opt => opt.MapFrom(src => src.NumeroNationalAnimal.Trim()))
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.Identite));
        }
    }
}