using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystemAPI.Data.Models
{
    public class LeaveRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeaveRequestId { get; set; }

        public int UserId { get; set; }

        public int LeaveType { get; set; }

        public DateTime LeaveStart { get; set; }

        public DateTime LeaveEnd { get; set; }

        public int Status { get; set; }
    }
}
