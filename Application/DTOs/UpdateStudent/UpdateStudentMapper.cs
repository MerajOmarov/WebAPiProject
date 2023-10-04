using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UpdateStudent
{
    public  class UpdateStudentMapper:Profile
    {
        public UpdateStudentMapper()
        {
            CreateMap<Students, UpdateStudentRespons>();
        }
    }
}
