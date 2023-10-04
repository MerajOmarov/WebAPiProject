using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UpdateStudent
{
    public  class UpdateStudentValidation:AbstractValidator<UpdateStudentRequest>
    {
        public UpdateStudentValidation()
        {
            RuleFor(x => x.NameOfStudent).NotEmpty().MinimumLength(3).MaximumLength(10);
            RuleFor(x => x.SernameOfStudent).NotEmpty().MinimumLength(3).MaximumLength(10);
            RuleFor(x => x.PhoneNumberOfStudent).NotEmpty();
            RuleFor(x => x.IdOfTecherInStudent).NotEmpty();
            RuleFor(x => x.MailOfStudent).NotEmpty().EmailAddress();

        }
    }
}
