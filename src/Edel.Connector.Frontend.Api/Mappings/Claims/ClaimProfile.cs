using System.Linq;
using AutoMapper;
using Edel.Connector.Frontend.Api.Models.Claims;
using Edel.Connector.Models;
using Edel.Connector.Services;

namespace Edel.Connector.Frontend.Api.Mappings.Claims
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            CreateMap<Claim, ClaimResponseModel>()
                .ForMember(dest => dest.ResourcePath, opt => opt.MapFrom(src => src.ResourcePath))
                .ForMember(dest => dest.Scopes,
                    opt => opt.ResolveUsing(o => o.Scopes.Select(c => c.ToString().ToLowerInvariant())));
        }


    }
}