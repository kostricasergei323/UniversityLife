using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using DAL.EF;
using DAL.Entities;

namespace DAL.Tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputEducationMaterialInstance_CalledAddMethodOfDBSetWithEducationMaterialInstance()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<EduInfoSystemContext>().Options;
            var mockContext = new Mock<EduInfoSystemContext>(opt);
            var mockDbSet = new Mock<DbSet<EducationMaterial>>();
            mockContext.Setup(context => context.Set<EducationMaterial>()).Returns(mockDbSet.Object);
            var repository = new TestEducationMaterialRepository(mockContext.Object);
            EducationMaterial expectedEducationMaterial = new Mock<EducationMaterial>().Object;

            repository.Create(expectedEducationMaterial);

            mockDbSet.Verify(dbSet => dbSet.Add(expectedEducationMaterial), Times.Once());
        }


        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<EduInfoSystemContext>().Options;
            var mockContext = new Mock<EduInfoSystemContext>(opt);
            var mockDbSet = new Mock<DbSet<EducationMaterial>>();
            mockContext.Setup(context => context.Set<EducationMaterial>()).Returns(mockDbSet.Object);


            EducationMaterial expectedEducationMaterial = new EducationMaterial() { EducationMaterialId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedEducationMaterial.EducationMaterialId)).Returns(expectedEducationMaterial);
            var repository = new TestEducationMaterialRepository(mockContext.Object);

            var actualEducationMaterial = repository.Get(expectedEducationMaterial.EducationMaterialId);

            mockDbSet.Verify(dbSet => dbSet.Find(expectedEducationMaterial.EducationMaterialId), Times.Once());
            Assert.Equal(expectedEducationMaterial, actualEducationMaterial);
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            DbContextOptions opt = new DbContextOptionsBuilder<EduInfoSystemContext>().Options;
            var mockContext = new Mock<EduInfoSystemContext>(opt);
            var mockDbSet = new Mock<DbSet<EducationMaterial>>();
            mockContext.Setup(context => context.Set<EducationMaterial>()).Returns(mockDbSet.Object);
            var repository = new TestEducationMaterialRepository(mockContext.Object);

            EducationMaterial expectedEducationMaterial = new EducationMaterial() { EducationMaterialId = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedEducationMaterial.EducationMaterialId)).Returns(expectedEducationMaterial);

            repository.Delete(expectedEducationMaterial.EducationMaterialId);

            mockDbSet.Verify(dbSet => dbSet.Find(expectedEducationMaterial.EducationMaterialId), Times.Once());

            mockDbSet.Verify(dbSet => dbSet.Remove(expectedEducationMaterial), Times.Once());
        }
    }
}
