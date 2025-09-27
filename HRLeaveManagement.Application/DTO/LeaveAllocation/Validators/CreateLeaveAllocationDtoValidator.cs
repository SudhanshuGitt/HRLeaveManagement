using FluentValidation;
using HRLeaveManagement.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveAllocationValidator(_leaveTypeRepository));
        }
    }
}
