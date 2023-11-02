using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Exceptions
{
    internal class InvalidPhoneNumber : Exception
    {
        public InvalidPhoneNumber()
        {
        }

        public InvalidPhoneNumber(string? message) : base(message)
        {
        }
    }
}
