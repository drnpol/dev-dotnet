using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
        
    }
}
