﻿using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
