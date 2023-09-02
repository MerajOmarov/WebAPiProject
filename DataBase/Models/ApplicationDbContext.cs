using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public  class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithOne(b => b.BookAuthor)
            .HasForeignKey(book => book.Book_Author_Id)
            .HasPrincipalKey(a=>a.Author_Id)
            .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(builder);


        }
    }
}
