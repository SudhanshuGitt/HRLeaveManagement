using FluentValidation;
using HRLeaveManagement.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveAllocation.Validators
{
    public class UpdateLeaveAllocationDtoValidator:AbstractValidator<UpdateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveAllocationValidator(_leaveTypeRepository));


            RuleFor(p => p.Id)
              .NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
