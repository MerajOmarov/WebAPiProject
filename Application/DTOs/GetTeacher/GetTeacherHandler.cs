using Application.Repositoties;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.GetUser
{
    public class GetTeacherHandler : IRequestHandler<GetTeacherRequest, GetTeacherRespons>
    {
        public IUnitOfWork UnitOfWork;
        public ITeacherRepository TeacherRepository;
        public IMapper mapper;

        public GetTeacherHandler(IUnitOfWork unitOfWork, ITeacherRepository teacherRepository, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            TeacherRepository = teacherRepository;
            this.mapper = mapper;
        }

        public async Task<GetTeacherRespons> Handle(GetTeacherRequest request, CancellationToken cancellationToken)
        {
            var result= await TeacherRepository.FindTeacher(request.Id);
            return mapper.Map<GetTeacherRespons>(result);
        }
    }
}
