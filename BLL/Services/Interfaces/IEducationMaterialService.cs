using System.Collections.Generic;
using BLL.DTO;

namespace BLL.Services.Interfaces
{
    public interface IEducationMaterialService
    {
        IEnumerable<EducationMaterialDTO> GetEducationMaterial(int page);
    }
}
