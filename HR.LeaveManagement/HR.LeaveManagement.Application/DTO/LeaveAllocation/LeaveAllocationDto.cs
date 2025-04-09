﻿using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.Common;
using HR.LeaveManagement.Application.DTO.LeaveType;


namespace HR.LeaveManagement.Application.DTO.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
