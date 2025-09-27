using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Persistance.Contracts
{
    public interface ILeaveRequestRepository :IGenricRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetials();
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetials();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? ApprovalStatus);

    }
}
