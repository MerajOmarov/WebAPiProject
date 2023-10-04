using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.GetStudent
{
    public class GetStudentRequest:IRequest<GetStudentRespons>
    {
        public int Id { get; set; }
    }
}
