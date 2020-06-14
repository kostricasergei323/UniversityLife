using System;
using System.Collections.Generic;
using System.Text;
using DAL.UnitOfWork;
using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private EduInfoSystemContext db;
        private EduInfoSystemRepository eduInfoSystemRepository;
        private EducationMaterialRepository eduMaterialRepository;

        public EFUnitOfWork(DbContextOptions options)
        {
            db = new EduInfoSystemContext(options);
        }

        public IRepository<EduInfoSystem> EduInfoSystems
        {
            get
            {
                if (eduInfoSystemRepository == null)
                    eduInfoSystemRepository = new EduInfoSystemRepository(db);
                return eduInfoSystemRepository;
            }
        }

        public IRepository<EducationMaterial> EduMaterials
        {
            get
            {
                if (eduMaterialRepository == null)
                    eduMaterialRepository = new EducationMaterialRepository(db);
                return eduMaterialRepository;
            }
        }

        IEduInfoSystemRepository IUnitOfWork.EduInfoSystems => throw new NotImplementedException();

        IEducationMaterialRepository IUnitOfWork.EduMaterials => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
