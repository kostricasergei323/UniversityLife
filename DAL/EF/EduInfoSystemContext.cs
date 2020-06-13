using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    class EduInfoSystemContext
        : DbContext
    {
        public DbSet<EduInfoSystem> Campus { get; set; }
        public DbSet<SystemRole> Orders { get; set; }

        public EduInfoSystemContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
