using LeaveManagementSystemAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystemAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}
