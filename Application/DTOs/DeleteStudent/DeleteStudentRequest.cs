using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.DeleteStudent
{
    public  class DeleteStudentRequest:IRequest<DeleteStudentRespons>
    {
        public int Id { get; set; }
    }
}
