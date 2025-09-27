using HRLeaveManagement.Application.DTO.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestRequest : IRequest<List<LeaveRequestListDto>>
    {
    }
}
