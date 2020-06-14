using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public class EduInfoSystemContext
        : DbContext
    {
        public DbSet<EduInfoSystem> Campus { get; set; }
        public DbSet<EducationMaterial> Materials { get; set; }

        public EduInfoSystemContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
