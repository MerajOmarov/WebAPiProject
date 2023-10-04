using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.GetUser
{
    public  class GetTeacherMapper:Profile
    {
        public GetTeacherMapper()
        {
            CreateMap<Teacher, GetTeacherRespons>(); 
        }
    }
}
