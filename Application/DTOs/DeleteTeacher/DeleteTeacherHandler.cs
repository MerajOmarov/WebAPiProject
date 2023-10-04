using Application.Repositoties;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DeleteUser
{
    public class DeleteTeacherHandler : IRequestHandler<DeleteTeacherRequest, DeleteTeacherRespons>
    {
        public IMapper mapper;
        public IUnitOfWork unitOfWork;
        public ITeacherRepository teacherRepository;
       

        public DeleteTeacherHandler(IMapper mapper, IUnitOfWork unitOfWork, ITeacherRepository teacherRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.teacherRepository = teacherRepository;
        }

        public async Task<DeleteTeacherRespons> Handle(DeleteTeacherRequest request, CancellationToken cancellationToken)
        {
           var result= await teacherRepository.FindTeacher(request.Id);
            teacherRepository.Delete(result);
            await unitOfWork.Save(cancellationToken);
            return mapper.Map<DeleteTeacherRespons>(result);
        }
    }
}
