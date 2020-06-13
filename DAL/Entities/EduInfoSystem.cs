using System.Collections.Generic;

namespace DAL.Entities
{
    public class EduInfoSystem
    {
        private List<Desk> InformationDesks { get; set; }
        private List<Group> UserGroups { get; set; }

        private static EduInfoSystem instance;

        private EduInfoSystem(List<Desk> informationDesks, List<Group> userGroups) { InformationDesks = informationDesks; UserGroups = userGroups; }

        public static EduInfoSystem getOrInitializeInstance(List<Desk> informationDesks = null, List<Group> userGroups = null)
        {
            if (instance == null && informationDesks != null && userGroups != null)
                instance = new EduInfoSystem(informationDesks, userGroups);
            return instance;
        }
    }
}
