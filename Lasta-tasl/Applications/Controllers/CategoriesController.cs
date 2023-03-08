using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DTOs;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    { 
        public ECommerceContext Context { get; set; }

        public CategoriesController(ECommerceContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
           var Categories= Context.Categories.Select(x=>new
           {
               x.Id,
               x.CatName,
               x.CatDescription,
               x.ParentCategory,
           });
            return Ok(Categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var _Category= Context.Categories.Find(id);
            if (_Category is null)
            {
                return NotFound($"category with id {id} is not found ");
            }
            return Ok(_Category);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id,[FromBody] categoryDto categoryDto) 
        {
            var _Category = Context.Categories.Find(id);
            if (_Category is null)
                return NotFound($"category with id {id} is not found ");

            _Category.Id = categoryDto.Id;
            _Category.CatName = categoryDto.CatName;
            _Category.CatDescription = categoryDto.CatDescription;
            _Category.ParentCategory= categoryDto.ParentCategory;

            Context.SaveChanges();
            return Ok(categoryDto);
        }
        [HttpPatch("{id}")]
        public IActionResult UpdateCategorypatch(int id, [FromBody] categoryDto categoryDto)
        {
            var _Category = Context.Categories.Find(id);
            if (_Category is null)
                return NotFound($"category with id {id} is not found ");
            _Category.CatName = categoryDto.CatName;
            Context.SaveChanges();
            return Ok(categoryDto);
        }


        [HttpPost]
        public IActionResult AddCategory([FromBody]categoryDto _categoryDto) 
        {
           
            var category = new global::Category
            {
                CatName= _categoryDto.CatName,
                CatDescription= _categoryDto.CatDescription,
            };

            Context.Categories.Add(category);
            Context.SaveChanges();
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var CategoryToDelete =  Context.Categories.Find(id);
            if (CategoryToDelete is null)
                return NotFound($"category with id {id} is not found ");
            Context.Categories.Remove(CategoryToDelete);
            Context.SaveChanges();
            return Ok(CategoryToDelete);
        }        
    }

}

