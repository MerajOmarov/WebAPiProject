using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositoties;
using Domain.Common;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T :BaseEntity
    {
        public  readonly DataContext Context;
        public BaseRepository( DataContext context) 
        {
           Context = context;
        }
        public void Create(T entity)
        {
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        

       

        
    }
}
