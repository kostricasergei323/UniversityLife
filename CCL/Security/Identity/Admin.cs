namespace CCL.Security.Identity
{
    public class Admin
        : User
    {
        public Admin(int userId, string name, string surname, int groupId)
            : base(userId, name, surname, groupId, nameof(Admin))
        {

        }
    }
}
