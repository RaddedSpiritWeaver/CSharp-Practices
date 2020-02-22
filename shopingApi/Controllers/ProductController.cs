using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using shopingApi.Models;

namespace shopingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    [ApiController]
    public class ProductController : Controller
    {
        // generate some psudo data to work with since we are not using a Database at the moment
        Product[] products = new Product[]
        {
           new Product {Id = 1, Name="pr1", Category="cat1", Price=20},
           new Product {Id = 2, Name="pr2", Category="cat2", Price=20},
           new Product {Id = 3, Name="pr3", Category="cat3", Price=20},
           new Product {Id = 4, Name="pr4", Category="cat4", Price=20}
        };

        // GET api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}