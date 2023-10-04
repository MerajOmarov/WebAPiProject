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

namespace Application.DTOs.DeleteStudent
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentRequest, DeleteStudentRespons>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IMapper mapper, IUnitOfWork unitOfWork, IStudentRepository studentRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
          
            _studentRepository = studentRepository;
        }

        public async Task<DeleteStudentRespons> Handle(DeleteStudentRequest request, CancellationToken cancellationToken)
        {
            Students student = await _studentRepository.FindStudent(request.Id);
            _studentRepository.Delete(student);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<DeleteStudentRespons>(student);
        }
    }
}
