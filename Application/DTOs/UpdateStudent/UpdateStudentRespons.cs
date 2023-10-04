using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UpdateStudent
{
    public  class UpdateStudentRespons
    {
        public int Id { get; set; }
        public int IdOfTecherInStudent { get; set; }
        public string NameOfStudent { get; set; }
        public string SernameOfStudent { get; set; }
        public string MailOfStudent { get; set; }
        public string PhoneNumberOfStudent { get; set; }
    }
}
