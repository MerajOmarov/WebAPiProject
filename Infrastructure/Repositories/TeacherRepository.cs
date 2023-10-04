using Application.Repositoties;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public  class TeacherRepository:BaseRepository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(DataContext context )
            :base(context)
        {

        }

        public async Task<Teacher> FindTeacher(int id)
        {
            var result = await Context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                return result;
            }
            throw new Exception("Not found Teacher");
        }
    }
}
