using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DeleteUser
{
    public  class DeleteTeacherMapper:Profile
    {
        public DeleteTeacherMapper()
        {
            CreateMap<DeleteTeacherRequest, Teacher>();
            CreateMap<Teacher, DeleteTeacherRespons>();
        }
    }
}
