using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string menssage) : base(menssage)
        {

        }
    }
}
