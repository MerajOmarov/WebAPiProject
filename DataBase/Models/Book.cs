using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public  class Book
    {
        [Key]
        public int Book_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Book_Author_Id { get;set; }
        public Author BookAuthor { get; set; }
    }
}
