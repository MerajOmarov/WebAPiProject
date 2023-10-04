using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CreateUser
{
    public  class CreateTeacherValidator:AbstractValidator<CreateTeacherRequest>
    {
        public CreateTeacherValidator()
        {
            RuleFor(x => x.MailOfTeacher).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.NameOfTeacher).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.SernameOfTeacher).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
