using System;
using System.Linq;
using AutoMapper;
using Edel.Connector.Api.Models;
using Edel.Connector.Api.Models.Claims;
using Edel.Connector.Api.Models.Users;

namespace Edel.Connector.Api.Mappings.Claims
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            CreateMap<Claim, ClaimResponseModel>()
                .ForMember(dest => dest.ResourcePath, opt => opt.MapFrom(src => src.ResourcePath))
                .ForMember(dest => dest.Scopes,
                    opt => opt.ResolveUsing(o => o.Scopes.Select(c => c.ToString().ToLowerInvariant())));

            CreateMap<ClaimRequestModel, Claim>()
                .ForMember(dest => dest.ResourcePath, opt => opt.MapFrom(src => src.ResourcePath))
                .ForMember(dest => dest.Scopes,
                    opt => opt.ResolveUsing(o =>
                        o.Scopes.Select(c => (ScopeType) Enum.Parse(typeof(ScopeType), c, true))));
        }


    }
}