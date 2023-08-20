using DataApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public BooksDbContext _books;
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var fruits = await Task.FromResult(new string[] { "Jack", "Joe", "Jill" });
            return Ok(fruits);
        }
       
        
    }
}
