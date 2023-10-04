using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositoties
{
    public  interface IStudentRepository:IBaseRepository<Students>
    {
        Task<Teacher> FindTeacher(int id);
        Task<Students> FindStudent(int id);
    }
}

