using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        public ECommerceContext ECommerceContext { get; set; }

        public BrandController(ECommerceContext eCommerceContext)
        {
            ECommerceContext = eCommerceContext;
        }
        [HttpPost]
        public IActionResult AddBrand( BrandDto brandDto)
        {
            var brand = new Brand { BrandName = brandDto.name };
            ECommerceContext.Brands.Add(brand);
            ECommerceContext.SaveChanges();
            return Ok(brand);
        }
        [HttpGet]
        public IActionResult GetAllBrands()
        {
            return Ok(ECommerceContext.Brands.OrderBy(x=>x.BrandName));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, [FromBody] BrandDto BrandDto) 
        {
            var Brand=await ECommerceContext.Brands.FirstOrDefaultAsync(x=>x.Id==id);
            if (Brand is null)
                return NotFound($"no Brand is Found with Id {id}");
            Brand.BrandName = BrandDto.name;
            ECommerceContext.SaveChanges();
            return Ok(Brand);
        }

        [HttpDelete("{id}")]
        public  ActionResult DeleteBrand(int id)
        {
            var Brand =  ECommerceContext.Brands.FirstOrDefault(x => x.Id == id);
            if (Brand is null)
                return NotFound($"no Brand is Found with Id {id}");       
            ECommerceContext.Brands.Remove(Brand);
            ECommerceContext.SaveChanges();
            return Ok(Brand);
        }
    }
}
public class BrandDto
{
    public int id { get; set; }
    [MaxLength(100)]
    public string name { get; set; }
}
