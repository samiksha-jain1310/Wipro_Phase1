using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "C# Basics", AuthorId = 1, Year = 2020 },
            new Book { Id = 2, Title = "ASP.NET Core Guide", AuthorId = 2, Year = 2021 }
        };

        private static List<Author> Authors = new List<Author>
        {
            new Author { Id = 1, Name = "John Doe" },
            new Author { Id = 2, Name = "Jane Smith" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(Books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> CreateBook([FromBody] Book book)
        {
            if (book == null) return BadRequest("Invalid book data");
            book.Id = Books.Count + 1;
            Books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");
            book.Title = updatedBook.Title;
            book.AuthorId = updatedBook.AuthorId;
            book.Year = updatedBook.Year;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound("Book not found");
            Books.Remove(book);
            return NoContent();
        }

        [HttpGet("authors/{authorId}/books")]
        public ActionResult<IEnumerable<Book>> GetBooksByAuthor(int authorId)
        {
            var booksByAuthor = Books.Where(b => b.AuthorId == authorId).ToList();
            if (!booksByAuthor.Any()) return NotFound("No books found for this author");
            return Ok(booksByAuthor);
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public int Year { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
