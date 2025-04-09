using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO.LeaveType
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
