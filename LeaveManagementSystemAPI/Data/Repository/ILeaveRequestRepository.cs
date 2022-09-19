using LeaveManagementSystemAPI.Data.Models;
using System.Collections.Generic;

namespace LeaveManagementSystemAPI.Data.Repository
{
    public interface ILeaveRequestRepository
    {
        int AddLeaveRequest(LeaveRequest leaveRequest);

        List<LeaveRequest> GetAllLeaveRequests();

        LeaveRequest GetLeaveRequestById(int id);

        void EditLeaveRequest(LeaveRequest leaveRequest);
    }
}
