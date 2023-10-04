
using Application.DTOs.GetStudent;
using Application.Features.GetUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace NewCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController:ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("Students{id}")]
        public async Task<IActionResult> GetStudent(int id, CancellationToken cancellationToken) 
        {  
            GetStudentRequest request = new GetStudentRequest();
            request.Id = id;
            var respons= await mediator.Send( request,cancellationToken);
            return Ok(respons);
        }

        [HttpGet("Teacher{id}")]
        public async Task<IActionResult> GetTeacher(int id, CancellationToken cancellationToken)
        {
            GetTeacherRequest request = new GetTeacherRequest();
            request.Id = id;
            var respons= await mediator.Send( request, cancellationToken);
            return Ok(respons);
        }
    }
}
