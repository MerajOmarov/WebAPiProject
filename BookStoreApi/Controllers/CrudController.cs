using DataApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private BooksDbContext _books;

        public UsersController(BooksDbContext books)
        {
           _books = books;

        }
     
        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] Books model)
        {

            
            _books.Add(model);
            _books.SaveChanges();

            return Ok(new { Message = "User Created" });
        }



        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Books model)
        {
            var existingBook = _books.Books.FirstOrDefault(b => b.ID == id);

            if (existingBook == null)
            {
                return NotFound();
            }
            existingBook.Title = model.Title;
            existingBook.Author = model.Author;
            _books.Books.Update(existingBook);
            _books.SaveChanges();

            return Ok(new { Message = "User Updated" });
        }

        [HttpGet]

        public IActionResult GetFun()
        {

            return Ok(_books.Books);
        }

    }
}
