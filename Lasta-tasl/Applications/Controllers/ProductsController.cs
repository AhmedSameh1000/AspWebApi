using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var Products = Context.Products;
            return Ok(Products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProductsById(int id)
        {
            var Products = Context.Products.Find(id);
            if (Products is null) return BadRequest($"product with id {id} is not found");
            return Ok(Products);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDto _ProductDto)
        {
            var productAdd = new Product
            {
                Name= _ProductDto.Name,
                 DiscountPercent= _ProductDto.DiscountPercent,
                 Discription= _ProductDto.Discription,
                 UnitPrice= _ProductDto.UnitPrice,
            };

            Context.Products.Add(productAdd);
            Context.SaveChanges();
            return Ok(productAdd);
        }
        [HttpPut("{id}")]
        public IActionResult  UpdateProduct  (int id, [FromBody]ProductDto _ProductDto)
        {
            var _product = Context.Products.Find(id);
            if (_product is null)
                return NotFound($"product with id {id} is not found ");

            _product.Discription = _ProductDto.Discription;
            _product.UnitPrice = _ProductDto.UnitPrice;
            _product.Name = _ProductDto.Name;
            _product.DiscountPercent = _ProductDto.DiscountPercent;

            Context.SaveChanges();
            return Ok(_product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var _product = Context.Products.Find(id);
            if (_product is null)
                return NotFound($"product with id {id} is not found to delete it ");

            Context.Products.Remove(_product);
            Context.SaveChanges();
            return Ok(_product);
        }
    }
   
}



