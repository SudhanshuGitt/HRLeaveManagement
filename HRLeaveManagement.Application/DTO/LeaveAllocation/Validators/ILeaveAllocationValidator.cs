using FluentValidation;
using HRLeaveManagement.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveAllocation.Validators
{
    public class ILeaveAllocationValidator : AbstractValidator<ILeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public ILeaveAllocationValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;


            RuleFor(p => p.NumberOfDays)
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComaparisonValue}");

            RuleFor(p => p.Period)
                .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");
               

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
