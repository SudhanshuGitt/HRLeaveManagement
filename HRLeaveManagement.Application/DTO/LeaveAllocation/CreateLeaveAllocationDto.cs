using HRLeaveManagement.Application.DTO.Common;
using HRLeaveManagement.Application.DTO.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveAllocation
{
    public class CreateLeaveAllocationDto : ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
