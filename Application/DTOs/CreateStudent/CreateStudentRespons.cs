using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.CreateStudent
{
    public  class CreateStudentRespons
    {
        public int IdOfTecherInStudent { get; set; }
        public string NameOfStudent { get; set; }
        public string SernameOfStudent { get; set; }
        public string MailOfStudent { get; set; }
        public string PhoneNumberOfStudent { get; set; }
    }
}
