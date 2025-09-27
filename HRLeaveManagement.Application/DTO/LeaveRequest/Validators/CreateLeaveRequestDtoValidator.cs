using FluentValidation;
using FluentValidation.Internal;
using HRLeaveManagement.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.DTO.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));
        }
    }
}
