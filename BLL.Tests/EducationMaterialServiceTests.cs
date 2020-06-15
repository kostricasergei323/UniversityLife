using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using AutoMapper;
using DAL.UnitOfWork;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using BLL.Services.Impl;
using BLL.Services.Interfaces;
using CCL.Security.Identity;
using CCL.Security;

namespace BLL.Tests
{
    public class EducationMaterialServiceTests
    {
        [Fact]
        public void Ctor_InputNull_ThrowArgummentNullException()
        {
            IUnitOfWork nullUnitOfWork = null;

            Assert.Throws<ArgumentNullException>(() => new EducationMaterialService(nullUnitOfWork));
        }
       
        [Fact]
        public void GetEducationMaterial_UsersIsAdmin_ThrowMethodAccessException()
        {
            User user = new Admin(1, "test name", "test surname", 1);
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            IEducationMaterialService educationMaterialService = new EducationMaterialService(mockUnitOfWork.Object);

            Assert.Throws<MethodAccessException>(() => educationMaterialService.GetEducationMaterial(0));
        }


        [Fact]
        public void GetEducationMaterial_EducationMaterialFromDAL_CorrectMappingToEducationMaterialDTO()
        {
            User user = new Moderator(1, "test name", "test surname", 1);
            SecurityContext.SetUser(user);
            var educationManterialService = GetEducationMaterialService();

            var actualEducationMaterialDTO = educationManterialService.GetEducationMaterial(0).GetEnumerator().Current;

            Assert.True(actualEducationMaterialDTO.EducationMaterialId == 1 && 
                actualEducationMaterialDTO.Name == "testName" && 
                actualEducationMaterialDTO.Content == "testContent");
        }



        IEducationMaterialService GetEducationMaterialService()
        {
            var mockContext = new Mock<IUnitOfWork>();
            var expectedEducationMaterial = new EducationMaterial()
            {
                EducationMaterialId = 1,
                Name = "testName",
                Content = "testContent"
            };

            var mockDbSet = new Mock<IEducationMaterialRepository>();
            mockDbSet.Setup(z => z.Find(It.IsAny<Func<EducationMaterial, bool>>(), It.IsAny<int>(), It.IsAny<int>())).Returns(new List<EducationMaterial>() { expectedEducationMaterial });
            mockContext.Setup(context => context.EduMaterials).Returns(mockDbSet.Object);

            IEducationMaterialService educationMaterialService = new EducationMaterialService(mockContext.Object);

            return educationMaterialService;
        }
    }
}
