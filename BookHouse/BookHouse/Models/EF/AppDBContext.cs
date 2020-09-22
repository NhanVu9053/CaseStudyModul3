using BookHouse.Models.Entities;

using BookHouse.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.EF
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options)
        {

        }

         
        public DbSet<DanhMucSach> DanhMucSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<KhachHang> KhachHangs { get; set; }

 
    }
}
