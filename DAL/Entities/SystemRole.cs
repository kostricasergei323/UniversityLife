using DAL.Enums;

namespace DAL.Entities
{
    public class SystemRole
    {
        public int SystemRoleId { get; set; }
        public string Name { get; set; }

        public RoleType Role { get; set; }

        public SystemRole(int roleId, string name, RoleType role)
        {
            SystemRoleId = roleId;
            Name = name;
            Role = role;
        }
    }
}