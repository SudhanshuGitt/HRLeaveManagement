using AutoMapper;
using HRLeaveManagement.Application.DTO.LeaveRequest;
using HRLeaveManagement.Application.Features.LeaveRequest.Requests.Queries;
using HRLeaveManagement.Application.Contracts.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestRequestHandler : IRequestHandler<GetLeaveRequestRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestRequest request, CancellationToken cancellationToken)
        {
          var leaveRequests =  await _leaveRequestRepository.GetLeaveRequestsWithDetials();
          return _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
            
        }
    }
}
