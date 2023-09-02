using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public  class Author
    {
        [Key]
        public int Author_Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
