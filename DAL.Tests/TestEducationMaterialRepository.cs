using DAL.Repositories.Impl;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Tests
{
    public class TestEducationMaterialRepository
        : BaseRepository<EducationMaterial>
    {
        public TestEducationMaterialRepository(DbContext context)
            : base(context)
        {

        }
    }
}
