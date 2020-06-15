using System;
using System.Collections.Generic;
using System.Text;
using BLL.Services.Interfaces;
using DAL.UnitOfWork;
using BLL.DTO;
using CCL.Security;
using CCL.Security.Identity;
using DAL.Entities;
using AutoMapper;

namespace BLL.Services.Impl
{
    public class EducationMaterialService
        : IEducationMaterialService

    {
        public readonly IUnitOfWork _database;
        public int pageSize = 10;

        public EducationMaterialService(IUnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }

        public IEnumerable<EducationMaterialDTO> GetEducationMaterial(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if(userType != typeof(Admin) && userType != typeof(Moderator))
            {
                throw new MethodAccessException();
            }

            var materialId = user.MateriallId;
            var educationMaterialEntities = _database.EduMaterials.Find(z => z.EducationMaterialId == materialId, pageNumber, pageSize);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<EducationMaterial, EducationMaterialDTO>()).CreateMapper();
            var materialsDTO = mapper.Map<IEnumerable<EducationMaterial>, List<EducationMaterialDTO>>(educationMaterialEntities);
            return materialsDTO;
        }
    }
}
