namespace DAL.Entities
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public SystemRole Role { get; set; }

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
