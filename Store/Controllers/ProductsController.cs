using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Store.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("api/products/{name?}")]
        public IActionResult GetAll(string name)
        {
            return Ok($"Test {name}");
        }
    }
}