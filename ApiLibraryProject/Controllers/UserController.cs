
using ApiLibraryProject.ActionFilters;
using DataBase.DTOs;
using DataBase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
            try
            {
                var authors = await Context.Author.ToListAsync();
                if (authors != null)
                {
                    return Ok(authors);
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Null Authors");
            }
            
        }

        
        [HttpGet("Books")]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                var books = await Context.Books.ToListAsync();
                if (books != null)
                {
                    return Ok(books);
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return StatusCode(500, "Null Books");
            }
        }


        [HttpGet("Book")]
        public async Task<IActionResult> SelectAbook(int Id)
        {
            try
            {
                var book = await Context.Books.FirstOrDefaultAsync(b => b.Book_Id == Id);
                if (book == null)
                {
                    throw new Exception();
                }
                return Ok(book);
            }
            catch (Exception)
            {
                return StatusCode(200, "Internal server error Meracccc");
            }
           
        }


        




    }
}
