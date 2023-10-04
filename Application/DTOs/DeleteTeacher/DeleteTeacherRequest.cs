using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.DeleteUser
{
    public class DeleteTeacherRequest:IRequest<DeleteTeacherRespons>
    {
        public int Id { get; set; }
    }
}
