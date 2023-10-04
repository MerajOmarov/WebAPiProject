using Domain.ApplicationUser;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public  class DataContext:IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
          
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Teacher>()
                   .HasMany<Students>(t => t.Students)
                   .WithOne(s => s.Teacher)
                   .HasForeignKey(s => s.IdOfTecherInStudent)
                   .HasPrincipalKey(t => t.Id)
                   .OnDelete(DeleteBehavior.Cascade);
                   

        }
    }
}
