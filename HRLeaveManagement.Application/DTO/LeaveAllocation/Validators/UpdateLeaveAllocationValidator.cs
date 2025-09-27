using FluentValidation;
using HRLeaveManagement.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveAllocation.Validators
{
    public class UpdateLeaveAllocationValidator:AbstractValidator<UpdateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveAllocationValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveAllocationValidator(_leaveTypeRepository));


            RuleFor(p => p.Id)
              .NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
