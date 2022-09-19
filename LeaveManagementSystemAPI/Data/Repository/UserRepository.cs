using LeaveManagementSystemAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagementSystemAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int AddUser(User user)
        {
            if (_dataContext != null)
            {
                _dataContext.Users.Add(user);
                _dataContext.SaveChanges();

                return user.UserId;
            }

            return 0;
        }

        public void EditUser(User user)
        {
            if (_dataContext != null)
            {
                var editUser = _dataContext.Users.FirstOrDefault(x => x.UserId.Equals(user.UserId));
                if(editUser != null)
                {
                    editUser.Name = user.Name;
                    editUser.Role = user.Role;
                    editUser.Username = user.Username;
                    editUser.Password = user.Password;
                }

                _dataContext.Update(editUser);
                _dataContext.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            if (_dataContext != null)
            {
                return _dataContext.Users.ToList();
            }

            return null;
        }

        public User GetUserById(int id)
        {
            if (_dataContext != null)
            {
                return _dataContext.Users.FirstOrDefault(x => x.UserId.Equals(id));
            }

            return null;
        }
    }
}
