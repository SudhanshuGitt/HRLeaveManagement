using HRLeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Domain
{
    public class LeaveType : BaseDomainIdentity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
