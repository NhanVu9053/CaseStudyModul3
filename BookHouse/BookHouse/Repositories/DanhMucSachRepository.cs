using BookHouse.Models.EF;
using BookHouse.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Repositories
{
    public class DanhMucSachRepository : IDanhMucSachRepository
    {
        private readonly AppDBContext context;

        public DanhMucSachRepository(AppDBContext context)
        {
            this.context = context;
        }
        public DanhMucSach Create(DanhMucSach danhMucSach)
        {
            context.DanhMucSachs.Add(danhMucSach);
            context.SaveChanges();
            return danhMucSach;
        }

        public bool Delete(int id)
        {
            var delDanhmuc = context.DanhMucSachs.Find(id);
            if (delDanhmuc != null)
            {
                context.DanhMucSachs.Remove(delDanhmuc);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public DanhMucSach Edit(DanhMucSach danhMucSach)
        {
            var editDanhMuc = context.DanhMucSachs.Attach(danhMucSach);
            editDanhMuc.State = EntityState.Modified;
            context.SaveChanges();
            return danhMucSach;
        }

        public DanhMucSach Get(int Id)
        {
            return context.DanhMucSachs.Find(Id);
        }

        public IEnumerable<DanhMucSach> Gets()
        {
            return context.DanhMucSachs;
        }
    }
}
