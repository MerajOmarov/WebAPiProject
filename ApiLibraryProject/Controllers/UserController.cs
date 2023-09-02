using DataBase.DTOs;
using DataBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLibraryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="User")]
    public class UserController : ControllerBase
    {
        public ApplicationDbContext Context { get; set; }

        public UserController(ApplicationDbContext context)
        {
            Context = context;
        }

        [HttpGet("Authors")]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await Context.Author.ToListAsync();
            return Ok(authors);
        }


        [HttpGet("Books")]
        public async Task<IActionResult> GetBooks()
        {
            var books= await Context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpGet("Book")]
        public async Task<IActionResult> GetBook([FromBody] DTU_GetBook BookModel)
        {
            var book = await Context.Books.FirstOrDefaultAsync(b=>b.Book_Id==BookModel.ID);
            return Ok(book);
        }




    }
}
