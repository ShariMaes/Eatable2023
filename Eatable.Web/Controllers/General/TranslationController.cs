using Eatable.Application.General;
using Eatable.Dto.General;
using Microsoft.AspNetCore.Mvc;

namespace Eatable.Web.Controllers.General
{
    [Route("translation")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly ITranslationManager _manager;
        public TranslationController(ITranslationManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("GetAllTranslations")]
        [Produces("application/json")]
        public async Task<List<TranslationDto>> GetAllTranslations()
        {
            var result = await _manager.GetAllTranslations();
            return result;
        }
    }

}
