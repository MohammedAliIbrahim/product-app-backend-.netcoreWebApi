using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication36.Models;
using WebApplication36.Repositories;

namespace WebApplication36.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
    private  IProductRepository _productRepository;

      
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Products
        [Route("/api/products")]
        [HttpGet]
        public IEnumerable<Product>GetProducts()
        {
            
            return  _productRepository.GetAllProducts();
        }

        [Route("/api/products/archive")]
        [HttpPost]
        public IActionResult ArchiveProducts([FromBody] myData data)
        {


            List<int> productsIds = new List<int>();
            foreach (var n in data.archives)
            {

                productsIds.Add(int.Parse(n));
            }
             _productRepository.Archive(productsIds);
            return Ok();
        }


    }

    public class myData
    {
     public List<string>   archives { get; set; }
    }
}
