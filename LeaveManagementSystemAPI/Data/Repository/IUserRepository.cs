using LeaveManagementSystemAPI.Data.Models;
using System.Collections.Generic;

namespace LeaveManagementSystemAPI.Data.Repository
{
    public interface IUserRepository
    {
        int AddUser(User user);

        List<User> GetAllUsers();

        User GetUserById(int id);

        void EditUser(User user);

    }
}
