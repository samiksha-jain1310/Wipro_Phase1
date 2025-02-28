using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MovieCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", DirectorId = 1, Year = 2010 },
            new Movie { Id = 2, Title = "Interstellar", DirectorId = 1, Year = 2014 }
        };

        private static List<Director> Directors = new List<Director>
        {
            new Director { Id = 1, Name = "Christopher Nolan" },
            new Director { Id = 2, Name = "Quentin Tarantino" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound("Movie not found");
            return Ok(movie);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie([FromBody] Movie movie)
        {
            if (movie == null) return BadRequest("Invalid movie data");
            movie.Id = Movies.Count + 1;
            Movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] Movie updatedMovie)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound("Movie not found");
            movie.Title = updatedMovie.Title;
            movie.DirectorId = updatedMovie.DirectorId;
            movie.Year = updatedMovie.Year;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound("Movie not found");
            Movies.Remove(movie);
            return NoContent();
        }

        [HttpGet("directors/{directorId}/movies")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByDirector(int directorId)
        {
            var moviesByDirector = Movies.Where(m => m.DirectorId == directorId).ToList();
            if (!moviesByDirector.Any()) return NotFound("No movies found for this director");
            return Ok(moviesByDirector);
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int DirectorId { get; set; }
        public int Year { get; set; }
    }

    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

