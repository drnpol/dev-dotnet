using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
