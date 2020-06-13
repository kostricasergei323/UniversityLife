using DAL.Enums;

namespace DAL.Entities
{
    public class SystemRole
    {
        private int SystemRoleId { get; set; }
        private string Name { get; set; }

        private RoleType Role { get; set; }

        public SystemRole(int roleId, string name, RoleType role)
        {
            SystemRoleId = roleId;
            Name = name;
            Role = role;
        }
    }
}