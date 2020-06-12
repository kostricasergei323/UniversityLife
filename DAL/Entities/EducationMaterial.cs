namespace DAL.Entities
{
    public class EducationMaterial
    {
        public int EducationMaterialId { get; set; }
        public string Name { get; set; }
        public SystemRole Role { get; set; }
        public string Content { get; set; }

        public EducationMaterial(int materialId, string name, SystemRole role, string content)
        {
            EducationMaterialId = materialId;
            Name = name;
            Role = role;
            Content = content;
        }
    }
}
