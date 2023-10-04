using Application.Repositoties;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GetStudent
{
    public class GetStudentHandler : IRequestHandler<GetStudentRequest, GetStudentRespons>
    {
        public IStudentRepository studentRepository;
        public IUnitOfWork unitOfWork;
        public IMapper mapper;

        public GetStudentHandler(IStudentRepository studentRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<GetStudentRespons> Handle(GetStudentRequest request, CancellationToken cancellationToken)
        {
            var student= await studentRepository.FindStudent(request.Id);
            studentRepository.Delete(student);
            return mapper.Map<GetStudentRespons>(student);
           
        }
    }
}
