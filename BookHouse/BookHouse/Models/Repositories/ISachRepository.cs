using BookHouse.Models.Entities;
using BookHouse.Models.ViewModel.SachViewmodel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Repositories
{
    public interface ISachRepository
    {
        IEnumerable<Sach> GetAll(int? id);
       int Get(int id);
       int Create(CreateViewModel sach, IFormFile[] image);
       int Edit(Sach sach);
       bool Delete(Sach sach);
    }
}
