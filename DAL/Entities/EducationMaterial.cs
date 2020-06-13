namespace DAL.Entities
{
    public class EducationMaterial
    {
        private int EducationMaterialId { get; set; }
        private string Name { get; set; }
        private SystemRole Role { get; set; }
        private string Content { get; set; }

        public EducationMaterial(int materialId, string name, SystemRole role, string content)
        {
            EducationMaterialId = materialId;
            Name = name;
            Role = role;
            Content = content;
        }
    }
}
