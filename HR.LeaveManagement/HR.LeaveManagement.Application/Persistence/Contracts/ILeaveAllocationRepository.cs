using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTO.LeaveAllocation;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocationDto> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocationDto>> GetLeaveAllocationsWithDetails();   
    }
}
