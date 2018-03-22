using Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding;
using Edel.Adventiel.Connector.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Edel.Adventiel.Connector.Api.Controllers.V1.Cattles.Breeding
{
    [Route("v1/cattle/pregnancy-check")]
    public class PregnancyCheckController : AbstractController<PregnancyCheckModel>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public PregnancyCheckController(ICrudPageableRepositoryAsync<PregnancyCheckModel> repository) : base(repository)
        {
        }
    }
}