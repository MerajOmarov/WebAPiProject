using Application.Repositoties;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class StudentRepository:BaseRepository<Students>, IStudentRepository
    {
        public StudentRepository( DataContext context)
            :base(context) 
        {

        }

        public async Task<Students> FindStudent(int id)
        {
            var result= await Context.Students.FirstOrDefaultAsync(t=>t.Id == id);
            if (result != null)
            {
                return result;
            }
            throw new Exception("Not found Student");
        }

        public async Task<Teacher> FindTeacher(int id)
        {
            var result = await Context.Teachers.FirstOrDefaultAsync(t => t.Id == id);
            if (result != null)
            {
                return result;
            }
            throw new Exception("Not found Teacher");
        }


    }
}
