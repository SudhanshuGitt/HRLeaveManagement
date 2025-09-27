using HRLeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace HRLeaveManagement.Domain
{
    public class LeaveAllocation : BaseDomainIdentity
    {

        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int Period { get; set; }

    }
}
