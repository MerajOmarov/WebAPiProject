using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CreateUser
{
    public sealed class CreateTeacherResponse
    {
        public string MailOfTeacher { get; set; }
        public string NameOfTeacher { get; set; }
        public string SernameOfTeacher { get; set; }
        public string PhoneNumberOfStudent { get; set; }
    }
}
