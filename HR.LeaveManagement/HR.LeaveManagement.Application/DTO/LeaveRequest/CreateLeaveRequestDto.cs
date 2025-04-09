using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO
{
    public class CreateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
    }
}