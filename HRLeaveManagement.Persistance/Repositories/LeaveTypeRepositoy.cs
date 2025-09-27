using HRLeaveManagement.Application.Contracts.Persistance;
using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Persistance.Repositories
{
    public class LeaveTypeRepositoy : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HRLeaveManagementDbContext _dbContext;

        public LeaveTypeRepositoy(HRLeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

       
    }
}
