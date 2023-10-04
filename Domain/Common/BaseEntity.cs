using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract  class BaseEntity
    {
        public DateTime RegistrationTime { get; set; }= DateTime.Now;
        public Guid Guid { get; set; }= Guid.NewGuid();
    }
}
