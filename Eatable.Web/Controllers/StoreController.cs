using Eatable.Application.StoreManager;
using Eatable.Dto.Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eatable.Web.Controllers
{
    [Route("store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreManager _storeManager;
        public StoreController(IStoreManager storeManager)
        {
            _storeManager = storeManager;
        }

        [HttpGet]
        [Route("getStoreList")]
        [Produces("application/json")]
        public async Task<List<StoreDto>> GetStoreList()
        {
            var result = await _storeManager.GetStoreList();
            return result;
        }

        //// GET api/<StoreController>/5
        //[HttpGet()]
        //[Route("GetStoreById")]
        //[Produces("application/json")]
        //public async Task<StoreDto> Get(Guid id)
        //{
        //    var result = await _storeManager.GetStoreById(id);
        //    return result;
        //}


        //// GET api/<StoreController>/5
        //[HttpGet()]
        //[Route("GetStoreByIdentifier")]
        //[Produces("application/json")]
        //public async Task<StoreDto> Get(string identifier)
        //{
        //    var result = await _storeManager.GetStoreByIdentifier(identifier);
        //    return result;
        //}


        //// POST api/<StoreController>
        //[HttpPost]
        //[Route("CreateStore")]
        //public void CreateStore([FromBody] string value)
        //{
        //}

        //// PUT api/<StoreController>/5
        //[HttpPut()]
        //[Route("UpdateStoreById")]
        //public void UpdateStoreById(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StoreController>/5
        //[HttpDelete()]
        //[Route("DeleteStoreById")]
        //public void Delete(int id)
        //{
        //}
    }
}
