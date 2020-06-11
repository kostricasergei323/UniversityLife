using System.Collections.Generic;

namespace DAL.Entities
{
    class Desk
    {
        public int DeskId { get; set; }
        public string Name { get; set; }
        public List<EducationMaterial> Materials { get; set; }

        public Desk(int deskId, string name, List<EducationMaterial> materials)
        {
            DeskId = deskId;
            Name = name;
            Materials = materials;
        }
    }
}
