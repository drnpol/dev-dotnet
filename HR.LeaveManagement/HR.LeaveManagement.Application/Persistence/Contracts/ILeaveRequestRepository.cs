using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Application.DTO.LeaveRequest;
using System.Threading.Tasks;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequestListDto> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequestListDto>> GetLeaveRequestsWithDetails();
    }
}
