using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    { 
        public ECommerceContext Context { get; set; }

        public CategoryController(ECommerceContext context)
        {
            this.Context = context;
        }
        [HttpGet("{action}")]
        public IActionResult GetAllCategories()
        {
           var Categories= Context.Categories;
            return Ok(Categories);
        }

        [HttpGet("{action}/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var Category = Context.Categories.FirstOrDefault(x=>x.Id==id);
            return Ok(Category);
        }
    }
}

