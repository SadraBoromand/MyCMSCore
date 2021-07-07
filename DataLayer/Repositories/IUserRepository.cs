using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.ViewModels.Auth;

namespace DataLayer.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        bool Register(RegisterViewModel register);
        User Login(LoginViewModel login);
        bool IsExsitUser(string email, string password);
    }
}
