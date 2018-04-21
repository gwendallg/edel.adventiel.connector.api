using AutoMapper;
using Edel.Adventiel.Connector.Entities.Cattles;
using WsMdBInterfaces;

namespace Edel.Adventiel.Connector.Mappings.Cattles
{
    public class CattleBreederProfile  : Profile
    {
        public CattleBreederProfile()
        {
            CreateMap<Bovin, CattleBreeder>()
                .ForMember(dest => dest.CattleCountryCode, opt => opt.MapFrom(src => src.CodePays))
                .ForMember(dest => dest.CattleIdentifier, opt => opt.MapFrom(src => src.NumeroNationalAnimal.Trim()))
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.Identite));
        }
    }
}