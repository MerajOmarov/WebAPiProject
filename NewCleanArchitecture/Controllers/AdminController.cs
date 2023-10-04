
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Features.CreateUser;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using Application.DTOs.CreateStudent;
using Application.DTOs.DeleteStudent;
using Application.Features.DeleteUser;
using Microsoft.OpenApi.Writers;
using Application.DTOs.UpdateStudent;

namespace NewCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<CreateTeacherRequest> _validator;
        public AdminController(IMediator mediator, IValidator<CreateTeacherRequest> validator)
        {
            _mediator = mediator;
            _validator = validator;
        }


        [HttpPost("Teacher")]
        public async Task<IActionResult>CreateTeacher(CreateTeacherRequest request, CancellationToken cancellation)
        {
            var respons = await _mediator.Send(request, cancellation);
            return Ok(respons);
        }

        [HttpPost("Student")]
        public async Task<IActionResult> CreateStudent(CreateStudentRequest request, CancellationToken cancellation)
        {
            var respons = await _mediator.Send(request, cancellation);
            return Ok(respons);
        }

        [HttpDelete("Student")]

        public async Task<IActionResult> DeleteStudent( DeleteStudentRequest request, CancellationToken cancellation)
        {
            var respons= await _mediator.Send(request,cancellation);
            return Ok(respons);
        }

        [HttpDelete("Teacher")]

        public async Task<IActionResult> DeleteTeacher( DeleteTeacherRequest request , CancellationToken cancellation)
        {
            var respons = await _mediator.Send(request, cancellation);
            return Ok(respons);
        }

        [HttpPut("Student")]

        public async Task<IActionResult>UpdateStudent(UpdateStudentRequest request, CancellationToken cancellation)
        {
            var respons = await _mediator.Send(request, cancellation);
            return Ok(respons);

        }

    }


}
