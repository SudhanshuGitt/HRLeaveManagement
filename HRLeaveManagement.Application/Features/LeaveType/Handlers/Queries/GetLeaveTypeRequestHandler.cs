using AutoMapper;
using HRLeaveManagement.Application.DTO.LeaveType;
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
    // tie a request to a handler
    // what request i am hndling and what should i expeting to reutrn
    // how object relate to each other this request will always relate to this handler
    public class GetLeaveTypeRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        // we need to do the mapping when we get data from the db
        // repo reutrn domain object we need to convert them to dto
        public GetLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAll();

            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
