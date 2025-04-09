using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO;
using HR.LeaveManagement.Application.DTO.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand: IRequest<int>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
    }
}
