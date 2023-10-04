using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Students:BaseEntity
    {
        public int Id { get; set; }
        public int IdOfTecherInStudent { get; set; }
        public string NameOfStudent { get; set; }
        public string SernameOfStudent { get; set; }
        public string MailOfStudent { get; set; }
        public string PhoneNumberOfStudent { get; set; }
        public Teacher Teacher { get; set; }
    }
}
