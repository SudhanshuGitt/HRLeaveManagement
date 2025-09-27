using HRLeaveManagement.Application.Contracts.Persistance;
using HRLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Persistance.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly HRLeaveManagementDbContext _dbContext;

        public LeaveRequestRepository(HRLeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approved = ApprovalStatus;
            // we are setting entity state as modified and then save changes
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetials()
        {
            var leaveReuests = await _dbContext.LeaveRequests.Include(l => l.LeaveType).ToListAsync();
            return leaveReuests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetials(int id)
        {
            var leaveRequest = await _dbContext.LeaveRequests.Include(l => l.LeaveType)
                .FirstOrDefaultAsync(l => l.Id == id);

            return leaveRequest;
        }
    }
}
