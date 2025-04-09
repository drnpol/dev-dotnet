using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {
        
    }
}
