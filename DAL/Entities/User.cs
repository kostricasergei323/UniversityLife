namespace DAL.Entities
{
    public class User
    {
        private int UserId { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private SystemRole Role { get; set; }

        public User(int userId, string name, string surname, string login, string password, SystemRole role)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            Role = role;
        }
    }
}
