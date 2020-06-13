using System.Collections.Generic;

namespace DAL.Entities
{
    public class Desk
    {
        private int DeskId { get; set; }
        private string Name { get; set; }
        private List<EducationMaterial> Materials { get; set; }

        public Desk(int deskId, string name, List<EducationMaterial> materials)
        {
            DeskId = deskId;
            Name = name;
            Materials = materials;
        }
    }
}
