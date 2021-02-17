using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BcProject.Models.Context
{
    public class BcDbContext:DbContext
    {
        public DbSet<AdminUser> Admin { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<WorkPictureList> PictureLists { get; set; }

    }
}