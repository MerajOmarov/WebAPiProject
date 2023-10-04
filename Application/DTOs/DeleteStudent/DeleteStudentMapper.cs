using Application.DTOs.CreateStudent;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.DeleteStudent
{
    public  class DeleteStudentMapper:Profile
    {
        public DeleteStudentMapper()
        {
            CreateMap<DeleteStudentRequest, Students>();
            CreateMap<Students, DeleteStudentRespons>();
        }
    }
}
