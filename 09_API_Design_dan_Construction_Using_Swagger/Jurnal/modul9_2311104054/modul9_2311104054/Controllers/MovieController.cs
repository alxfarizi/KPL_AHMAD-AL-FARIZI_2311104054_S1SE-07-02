using System;
using Microsoft.AspNetCore.Mvc;
using modul9_2311104054.Models;

namespace modul9_2311104054.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
	{
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id >= 0 && id < movies.Count)
            {
                return movies[id];
            }
            return NotFound();
        }

        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < movies.Count)
            {
                movies.RemoveAt(id);
            }
        }
    }
}

