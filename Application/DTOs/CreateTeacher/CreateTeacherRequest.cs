using FluentNHibernate.Automapping;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CreateUser
{
    
    public  class CreateTeacherRequest:IRequest<CreateTeacherResponse>
    {
        public string MailOfTeacher { get; set; }
        public string NameOfTeacher { get; set; }
        public string SernameOfTeacher { get; set; }
        public string PhoneNumberOfStudent { get; set; }
    }
}
