using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.ViewModels.Auth;

namespace DataLayer.Services
{
    public class UserReopsitory : IUserRepository
    {
        private MyCMSContext db;

        public UserReopsitory(MyCMSContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return db.Users;
        }

        public bool Register(RegisterViewModel register)
        {
            if (IsExsitUser(register.Email, register.Password))
            {
                return false;
            }

            db.Users.Add(new User()
            {
                Email = register.Email.ToLower(),
                Password = register.Password,
                Role = 2
            });
            db.SaveChanges();

            return true;
        }

        public User Login(LoginViewModel login)
        {
            return db.Users.SingleOrDefault(u => u.Email == login.Email.ToLower() && u.Password == login.Password);
        }

        public bool IsExsitUser(string email, string password)
        {
            return db.Users.Any(u => u.Email == email.ToLower() && u.Password == password);
        }
    }
}
