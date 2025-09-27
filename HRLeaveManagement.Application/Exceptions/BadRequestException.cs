using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Exceptions
{
    // Application Exception is base type for application defined exception
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message): base(message)
        {
            
        }
    }
}
