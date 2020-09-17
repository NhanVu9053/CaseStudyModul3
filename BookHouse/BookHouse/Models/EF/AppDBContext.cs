using BookHouse.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.EF
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options)
        {

        }

         
        public DbSet<DanhMucSach> DanhMucSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }
    }
}
