using LeaveManagementSystemAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagementSystemAPI.Data.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly DataContext _dataContext;

        public LeaveRequestRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int AddLeaveRequest(LeaveRequest leaveRequest)
        {
            if (_dataContext != null)
            {
                _dataContext.LeaveRequests.Add(leaveRequest);
                _dataContext.SaveChanges();

                return leaveRequest.LeaveRequestId;
            }

            return 0;
        }

        public void EditLeaveRequest(LeaveRequest leaveRequest)
        {
            if (_dataContext != null)
            {
                var editLeaveRequest = _dataContext.LeaveRequests.FirstOrDefault(x => x.LeaveRequestId.Equals(leaveRequest.LeaveRequestId));
                if(editLeaveRequest != null)
                {
                    editLeaveRequest.LeaveType = leaveRequest.LeaveType;
                    editLeaveRequest.LeaveStart = leaveRequest.LeaveStart;
                    editLeaveRequest.LeaveEnd = leaveRequest.LeaveEnd;
                    editLeaveRequest.Status = leaveRequest.Status;
                }

                _dataContext.LeaveRequests.Update(editLeaveRequest);
                _dataContext.SaveChanges();
            }
        }

        public List<LeaveRequest> GetAllLeaveRequests()
        {
            if (_dataContext != null)
            {
                return _dataContext.LeaveRequests.ToList();
            }

            return null;
        }

        public LeaveRequest GetLeaveRequestById(int id)
        {
            if (_dataContext != null)
            {
                return _dataContext.LeaveRequests.FirstOrDefault(x => x.LeaveRequestId.Equals(id));
            }

            return null;
        }
    }
}
