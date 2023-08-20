using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public  class Books
    {
        [Key]
        public int ID { get; set; }
        public int Title { get; set; }
        public int Author { get; set; }
    }
}
