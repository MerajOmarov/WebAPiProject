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
    [Authorize(Roles ="Admin")]
    public class AdminController : ControllerBase
    {
        public ApplicationDbContext Context { get; set; }

        public AdminController(ApplicationDbContext context)
        { 
               Context = context;
        }

        [HttpPost("Author")]
        public async Task<IActionResult> PostAuthors([FromBody] DTU_PostAuthor ModelAuthor)
        {
            Context.Author.Add(new Author { Name = ModelAuthor.NameOfAuthor });
            await Context.SaveChangesAsync();
            return Ok("Successfully!!");
        }


        [HttpDelete("Authors/id")]
        public async Task<IActionResult> DeleteAuthor([FromBody] DTU_DeleteAuthor ModelAuthor)
        {
            Author author = await Context.Author.FirstOrDefaultAsync(a => a.Author_Id == ModelAuthor.ID);
            Context.Author.Remove(author);
            await Context.SaveChangesAsync();
            return Ok("Successfully!!");
        }


        [HttpPost("Books")]
        public async Task<IActionResult> PostBook([FromBody] DTU_PostBook ModelBook)
        {
            Author author = await Context.Author.FirstOrDefaultAsync(a => a.Author_Id == ModelBook.Author_ID);
            Context.Books.Add(new Book { BookAuthor = author, Description = ModelBook.Description, Name = ModelBook.Name, Book_Author_Id = author.Author_Id });
            await Context.SaveChangesAsync();
            return Ok("Successfully!!");
        }


        [HttpDelete("Books/id")]
        public async Task<IActionResult> DeleteBook([FromBody] DTU_DeleteBook ModelBook)
        {
            Book book = await  Context.Books.FirstOrDefaultAsync(b => b.Name == ModelBook.NameOfBook);
            Context.Books.Remove(book);
            await Context.SaveChangesAsync();
            return Ok("Successfully!!");
        }



    }
}
