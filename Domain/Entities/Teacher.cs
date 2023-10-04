using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Teacher:BaseEntity
    {
        public  int Id  { get; set; } 
        public string NameOfTeacher { get; set; }
        public string SernameOfTeacher { get; set; }
        public string MailOfTeacher { get; set; }
        public string PhoneNumberOfStudent { get; set; }
        public List<Students> Students { get; set; }
    }
}
