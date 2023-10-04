using AutoMapper;
using Domain.Entities;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.CreateStudent
{
    public  class CreateStudentMapper:Profile
    {
        public CreateStudentMapper()
        {
            CreateMap<CreateStudentRequest, Students>();
            CreateMap<Students, CreateStudentRespons>();
        }
    }
}
