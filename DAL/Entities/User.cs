using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public SystemRole UserRole { get; set; }
    }

    public abstract class UserBuilder
    {
        public abstract void FillUserIdAndName(int userId, string name);
        public abstract void FillUserCredentials(string login, string password);
        public abstract void FillUserRole(SystemRole userRole);
        public abstract User GetUser();
    }

    public class ConcreteUserBuilder: UserBuilder
    {
        public User user = new User();

        public override void FillUserIdAndName(int userId, string name)
        {
            user.UserId = userId;
            user.Name = name;
        }

        public override void FillUserCredentials(string login, string password)
        {
            user.Login = login;
            user.Password = password;
        }

        public override void FillUserRole(SystemRole userRole)
        {
            user.UserRole = userRole;
        }

        public override User GetUser()
        {
            return user;
        }
    }
}
