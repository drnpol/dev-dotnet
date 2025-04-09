using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand: IRequest<int>
    {
        public CreateLeaveRequestDto CreateLeaveRequestDto { get; set; }
    }
}
