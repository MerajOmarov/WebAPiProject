using Application.Features.CreateUser;
using Application.Repositoties;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.CreateStudent
{
    public  class CreateStudentHandler:IRequestHandler<CreateStudentRequest, CreateStudentRespons>
    {
        private readonly IMapper _mapper;
        private readonly IValidator<CreateStudentRequest> _validator;
        private readonly IStudentRepository studentRepository;
        private readonly IUnitOfWork unitOfWork;
        public CreateStudentHandler(IMapper mapper, IValidator<CreateStudentRequest> validator, IStudentRepository _studentRepository, IUnitOfWork _unitOfWork)
        {
           _mapper = mapper;
           _validator = validator;
           studentRepository = _studentRepository;
            unitOfWork = _unitOfWork;
        }

        public async Task<CreateStudentRespons> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
        {
            var result = await _validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                throw new Exception("Validation Error");
            }
            var student= _mapper.Map<Students>(request);
            var teacher=studentRepository.FindTeacher(student.IdOfTecherInStudent);
            student.Teacher = await teacher;
            studentRepository.Create(student);
            await  unitOfWork.Save(cancellationToken);
            return _mapper.Map<CreateStudentRespons>(student);
            
        }
    }
}
