using BookHouse.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Repositories
{
   public interface IDanhMucSachRepository
    {
        IEnumerable<DanhMucSach> Gets();
        DanhMucSach Get(int Id);
        DanhMucSach Create(DanhMucSach danhMucSach);
        DanhMucSach Edit(DanhMucSach danhMucSach);
        bool Delete(int id);
    }
}
