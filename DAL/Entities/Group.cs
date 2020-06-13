using System.Collections.Generic;

namespace DAL.Entities
{
    public class Group
    {
        private int GroupId { get; set; }
        private string Name { get; set; }
        private SystemRole Role { get; set; }
        private List<User> Users { get; set; }

        public Group(int groupId, string name, SystemRole role, List<User> users)
        {
            GroupId = groupId;
            Name = name;
            Role = role;
            Users = users;
        }
    }
}
