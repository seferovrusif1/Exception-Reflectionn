using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Exceptions
{
    internal class PasswordException : Exception
    {
        public PasswordException()
        {
        }

        public PasswordException(string? message) : base(message)
        {
        }
    }
}
