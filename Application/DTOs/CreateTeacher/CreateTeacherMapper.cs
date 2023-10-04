using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CreateUser
{
    public sealed class CreateTeacherMapper:Profile
    {
        public CreateTeacherMapper()
        {
            CreateMap<CreateTeacherRequest, Teacher>();
            CreateMap<Teacher, CreateTeacherResponse>();
        }
    }
}
