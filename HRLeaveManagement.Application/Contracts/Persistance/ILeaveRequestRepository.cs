using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Contracts.Persistance
{
    public interface ILeaveRequestRepository :IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetials(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetials();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? ApprovalStatus);

    }
}
