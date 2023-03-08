using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private new List<string> _allowedExtensions = new List<string>
        {
            ".jpg",".png"
        };
        private long _maxAllowedPosterSize =1048576 ;
        private ECommerceContext Context { get; set; }
        public MoviesController(ECommerceContext context)
        {
            Context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        { 
           var movies = await Context.movies.Select(x => new{x.Id,x.Title,x.Rate,x.StoreLine,x.Year,x.Genre.Name}).OrderByDescending(m=>m.Rate).ToListAsync();           
            return Ok(movies);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetMovieById(int Id)
        {
            var movie = await Context.movies.Include(x=>x.Genre).SingleOrDefaultAsync(z=>z.Id==Id);
            if (movie is null)
            {
                return NotFound($"Movie with id {Id} is not found");
            }
            var MovieDto = new {
                movie.Title,
                movie.Rate,
                movie.StoreLine,
                movie.Year,
                movie.GenreId,
                movie.Poster,
                movie.Genre.Name
 
            };
            return Ok(MovieDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] MovieDto movieDto)
        {
            if (!_allowedExtensions.Contains(Path.GetExtension(movieDto.Poster.FileName.ToLower())))
            {
                return BadRequest("Only .png and Jpg Imges are Allowed");

            }
            if (movieDto.Poster.Length > _maxAllowedPosterSize)
            {
                return BadRequest("Max Alowed Size For Poster is 1MB");
            }
            var GenreIsValid = await Context.genres.AnyAsync(g => g.Id == movieDto.GenreId);
            if (!GenreIsValid) 
            {
                return BadRequest("Genre Id is Not Found");
            }
            using var dataStream = new MemoryStream();        
                await movieDto.Poster.CopyToAsync(dataStream);      
            var Movie = new Movie
            {
                GenreId = movieDto.GenreId,
                Title = movieDto.Title,
                Poster = dataStream.ToArray(),
                Rate = movieDto.Rate,
                StoreLine = movieDto.StoreLine,
                Year = movieDto.Year
            };
            await Context.AddAsync(Movie);
            Context.SaveChanges();
            return Ok(Movie);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var MovieToDelete = await Context.movies.FindAsync(id);
            if (MovieToDelete is null)
                return NotFound($"movie with id {id} is not found ");
            Context.movies.Remove(MovieToDelete);
            Context.SaveChanges();
            return Ok(MovieToDelete);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id,[FromForm]MovieDto movieDto)
        {
            var Movie = await Context.movies.FindAsync(id);
        
            if (Movie is null)
                return NotFound($"movie with id {id} is not fount");
          
            var GenreIsValid = await Context.genres.AnyAsync(g => g.Id == movieDto.GenreId);
            if (!GenreIsValid)
                return BadRequest("Genre Id is Not Found");

            if (movieDto.Poster != null)
            {
                if (!_allowedExtensions.Contains(Path.GetExtension(movieDto.Poster.FileName.ToLower())))
                    return BadRequest("Only .png and Jpg Imges are Allowed");

                if (movieDto.Poster.Length > _maxAllowedPosterSize)
                    return BadRequest("Max Alowed Size For Poster is 1MB");

                using var dataStream = new MemoryStream();
                await movieDto.Poster.CopyToAsync(dataStream);

                Movie.Poster=dataStream.ToArray();
            }   

            if(Movie is null) return NotFound($"movie with id {id} is not found ");
            Movie.Title= movieDto.Title;
            Movie.Year= movieDto.Year;
            Movie.StoreLine = movieDto.StoreLine;
            Movie.Rate = movieDto.Rate;
            Movie.GenreId= movieDto.GenreId;
          
            Context.SaveChanges();
            return Ok(movieDto);
        }
    }
}
public class MovieDto
{
    [MaxLength(250)]
    public string Title { get; set; }
    public int Year { get; set; }
    public double Rate { get; set; }
    [MaxLength(25000)]
    public string StoreLine { get; set; }
    public IFormFile? Poster { get; set; }
    public byte GenreId { get; set; }
}