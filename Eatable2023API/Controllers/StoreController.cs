using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eatable.Application.Product;
using Eatable.Dto.Product;
using Microsoft.AspNetCore.Mvc;

namespace Eatable.API.Controllers
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

        // GET: api/<StoreController>
        [HttpGet]
        [Route("GetStoreList")]
        [Produces("application/json")]
        public IEnumerable<StoreDto> GetStoreList()
        {
            var result = _storeManager.GetStoreList();
            return result;
        }

        // GET api/<StoreController>/5
        [HttpGet()]
        [Route("GetStoreById")]
        [Produces("application/json")]
        public async Task<StoreDto> Get(Guid id)
        {
            var result = await _storeManager.GetStoreById(id);
            return result;
        }


        // GET api/<StoreController>/5
        [HttpGet()]
        [Route("GetStoreByIdentifier")]
        [Produces("application/json")]
        public async Task<StoreDto> Get(string identifier)
        {
            var result = await _storeManager.GetStoreByIdentifier(identifier);
            return result;
        }


        // POST api/<StoreController>
        [HttpPost]
        [Route("CreateStore")]
        public void CreateStore([FromBody] string value)
        {
        }

        // PUT api/<StoreController>/5
        [HttpPut()]
        [Route("UpdateStoreById")]
        public void UpdateStoreById(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreController>/5
        [HttpDelete()]
        [Route("DeleteStoreById")]
        public void Delete(int id)
        {
        }
    }
}
