using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.Common;


namespace HR.LeaveManagement.Application.DTO
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
