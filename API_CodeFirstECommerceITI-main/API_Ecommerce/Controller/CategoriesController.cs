using Application.Features.Categories.Commands.CreateCategory;
using Application.Features.Categories.Commands.DeleteCategory;
using Application.Features.Categories.Commands.EditCategory;
using Application.Features.Categories.Queries.FilterCategories;
using Application.Features.Categories.Queries.GetCategoryDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ecommerce.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {      
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task< IActionResult> GetAllCategories([FromQuery] string ? Filter =null,int ? parentCategoryId=null)
        {
            return Ok(await mediator.Send(new FiltersCategoriesQuery(Filter,parentCategoryId)));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryDetails(int id, [FromQuery] GetCategoryDetailsQuery command)
        {
            command.Id = id;
            return Ok(await mediator.Send(command));
        }
        [HttpPost]
        public async Task< IActionResult> AddCategory([FromBody] CreateCategoryCommand query)
        {
            return Ok(await mediator.Send(query));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id,[FromBody] UpdateCategoryCommand command)
        {
            command.Id = id;
            return Ok(await mediator.Send(command));
           
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id,[FromQuery] DeleteCategoryCommand command)
        {
            command.Id = id;
            return Ok(await mediator.Send(command));
        }
    }
}
