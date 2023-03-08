using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ECommerceContext Context { get; set; }

        public ProductController(ECommerceContext context)
        {
            this.Context = context;
        }
        [HttpGet("{action}")]
        public IActionResult GetAllProducts()
        {
            var Products=Context.Products;
            return Ok(Products);
        }
        [HttpGet("{action}/{CategoryId}")]
        public IActionResult GetAllProductsByCategoryId(int CategoryId)
        {
            var Products=Context.Products.Where(x=>x.Category.Id==CategoryId);
            return Ok(Products);
        }
        [HttpGet("{action}/{ProductId}")]
        public IActionResult GetProductById(int ProductId)
        {
            var Products = Context.Products.FirstOrDefault(x => x.Id == ProductId);
            return Ok(Products);
        }    
    }
}



