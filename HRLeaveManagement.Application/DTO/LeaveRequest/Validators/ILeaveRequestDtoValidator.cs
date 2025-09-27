using FluentValidation;
using HRLeaveManagement.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveRequest.Validators
{
    public class ILeaveRequestDtoValidator: AbstractValidator<ILeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public ILeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            RuleFor(p => p.StartDate)
                .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(p => p.EndDate)
                .LessThan(p => p.StartDate).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                // token is cancellation token
                .MustAsync(async (id, token) =>
                {
                    // check if the leavetypeid exists
                    var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                    return !leaveTypeExists;

                }).WithMessage("{PropertyName} does not exist.");
            
        }
    }
}
