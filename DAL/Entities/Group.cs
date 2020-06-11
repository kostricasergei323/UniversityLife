using System.Collections.Generic;

namespace DAL.Entities
{
    class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public SystemRole Role { get; set; }
        public List<User> Users { get; set; }

        public Group(int groupId, string name, SystemRole role, List<User> users)
        {
            GroupId = groupId;
            Name = name;
            Role = role;
            Users = users;
        }
    }
}
