using AutoMapper;
using HRLeaveManagement.Application.DTO.LeaveType;
using HRLeaveManagement.Application.Features.LeaveRequest.Requests.Queries;
using HRLeaveManagement.Application.Contracts.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveTypeDetialRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetialRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveRequestRepository.Get(request.Id);

            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
