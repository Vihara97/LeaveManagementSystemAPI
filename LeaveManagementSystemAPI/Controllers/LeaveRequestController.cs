using LeaveManagementSystemAPI.Data.Models;
using LeaveManagementSystemAPI.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LeaveManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public LeaveRequestController(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
        }

        [HttpGet]
        [Route("GetAllLeaveRequests")]
        public IEnumerable<LeaveRequest> GetAllLeaveRequests()
        {
            return _leaveRequestRepository.GetAllLeaveRequests();
        }

        [HttpPost]
        [Route("AddLeaveRequest")]
        public IActionResult AddLeaveRequest(LeaveRequest leaveRequest)
        {
            _leaveRequestRepository.AddLeaveRequest(leaveRequest);
            return Ok();
        }

        [HttpPut]
        [Route("EditLeaveRequest")]
        public IActionResult EditLeaveRequest(LeaveRequest leaveRequest)
        {
            _leaveRequestRepository.EditLeaveRequest(leaveRequest);
            return Ok();
        }

        [HttpGet]
        [Route("GetLeaveRequestById")]
        public LeaveRequest GetLeaveRequestById(int id)
        {
            return _leaveRequestRepository.GetLeaveRequestById(id);
        }
    }
}
