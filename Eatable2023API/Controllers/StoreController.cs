using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eatable2023API.Controllers
{
    [Route("store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        public StoreController()
        {

        }

        // GET: api/<StoreController>
        [HttpGet]
        [Route("GetStoreList")]
        [Produces("application/json")]
        public IEnumerable<string> GetStoreList()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StoreController>/5
        [HttpGet()]
        [Route("GetStoreById")]
        [Produces("application/json")]
        public string Get(int id)
        {
            return "value";
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
