using ApiLibraryProject.ActionFilters;
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
        [ServiceFilter(typeof(ValidationFilter))]
        public async Task<IActionResult> PostAuthors([FromBody] PostAuthorModel ModelAuthor)
        {
            try
            {
                var author = new Author { Name = ModelAuthor.NameOfAuthor };
                if (author != null)
                {
                    Context.Author.Add(author);
                    await Context.SaveChangesAsync();
                    return Ok("Successfully!!");
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Unsuccessfully creating!!!");

            }
        }    

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpDelete("Authors/id")]
        public async Task<IActionResult> DeleteAuthor([FromBody] DeleteAuthoModel ModelAuthor)
        {
            try
            {
                var author = await Context.Author.FirstOrDefaultAsync(a => a.Author_Id == ModelAuthor.ID);
                if (author != null)
                {
                    Context.Author.Remove(author);
                    await Context.SaveChangesAsync();
                    return Ok("Successfully!!");
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Unsuccessfully remove!!!");
            }
            
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost("Books")]
        public async Task<IActionResult> PostBook([FromBody] PostBookModel ModelBook)
        {
            try
            {
                var author = await Context.Author.FirstOrDefaultAsync(a => a.Author_Id == ModelBook.Author_ID);
                if (author != null) 
                {
                    Context.Books.Add(new Book { BookAuthor = author, Description = ModelBook.Description, Name = ModelBook.Name, Book_Author_Id = author.Author_Id });
                    await Context.SaveChangesAsync();
                    return Ok("Successfully!!");
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Unsuccessfully creating!!!");
            }
           
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpDelete("Books/id")]
        public async Task<IActionResult> DeleteBook([FromBody] DeleteBookModel ModelBook)
        {
            try
            {
                var book = await Context.Books.FirstOrDefaultAsync(b => b.Name == ModelBook.NameOfBook);
                if (book != null)
                {
                    Context.Books.Remove(book);
                    await Context.SaveChangesAsync();
                    return Ok("Successfully!!");
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Unsuccessfully remove!!!");
            }
         
        }



    }
}
