using System;
using System.Collections.Generic;
using System.Text;
using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEduInfoSystemRepository EduInfoSystems { get; }
        IEducationMaterialRepository EduMaterials { get; }
        void Save();
    }
}
