using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMHS.DATA;

namespace SAMHS.DAL.Interfaces
{
    public interface IUser
    {
        List<User> ListUsers();
        void AddUser(User user);
        void CreatedUserAccountSentEmail(string email, string name);
        User SearchUser(int userId);

        void EditUser(User user);
        void DeleteUser(int userId);
        bool UserLogin(int userId, string userPassword);

    }
}
