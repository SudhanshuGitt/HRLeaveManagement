using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Responses
{
    public class BaseCommandResponse
    {
        public object? data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } 
        public List<string> Errors { get; set; }
    }
}
