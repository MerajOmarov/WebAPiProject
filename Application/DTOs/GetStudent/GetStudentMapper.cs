using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GetStudent
{
    public  class GetStudentMapper:Profile
    {
       public GetStudentMapper() 
       {
            CreateMap<GetStudentRequest, Students>();
            CreateMap<Students, GetStudentRespons>();
       }
    }
}
