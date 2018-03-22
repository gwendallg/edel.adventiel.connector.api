using Edel.Adventiel.Connector.Api.Models.V1.Cattles;
using Edel.Adventiel.Connector.Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edel.Adventiel.Connector.Api.Controllers.V1
{
    [Authorize]
    [Route("v1/cattle")]
    public class CattleController : AbstractController<CattleModel>
    {
        public CattleController(ICrudPageableRepositoryAsync<CattleModel> repository) : base(repository)
        {
        }
    }
}