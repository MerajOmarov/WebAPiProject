using Application.Repositoties;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UpdateStudent
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentRequest, UpdateStudentRespons>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper Mapper;
        public IValidator<UpdateStudentRequest> Validator;
        public IStudentRepository StudentRepository;

        public UpdateStudentHandler(IUnitOfWork unitOfWork, IMapper mapper, IValidator<UpdateStudentRequest> validator, IStudentRepository studentRepository)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
            Validator = validator;
            StudentRepository = studentRepository;
        }

        public async Task<UpdateStudentRespons> Handle(UpdateStudentRequest request, CancellationToken cancellationToken)
        {
            var respons= await Validator.ValidateAsync(request);
            if (respons!=null)
            {
                var result = await StudentRepository.FindStudent(request.Id);
                result.IdOfTecherInStudent = request.IdOfTecherInStudent;
                result.PhoneNumberOfStudent = request.PhoneNumberOfStudent;
                result.NameOfStudent = request.NameOfStudent;
                result.SernameOfStudent = request.SernameOfStudent;
                await UnitOfWork.Save(cancellationToken);
                return Mapper.Map<UpdateStudentRespons>(result);
            }
            throw new Exception("Validation Error");
       
        }
    }
}
