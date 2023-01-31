using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eatable.API.Controllers
{
   
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
        }

        // GET: api/<ProductController>
        [HttpGet]
        [Route("GetProductList")]
        [Produces("application/json")]
        public IEnumerable<string> GetProductList()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet]
        [Route("GetProductById")]
        [Produces("application/json")]
        public string GetProductById(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("CreateProduct")]
        public void CreateProduct([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        [Route("UpdateProductById")]
        public void UpdateProductById(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        [Route("DeleteProductById")]
        public void DeleteProductById(int id)
        {
        }
    }
}
