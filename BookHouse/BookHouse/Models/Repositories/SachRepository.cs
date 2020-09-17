using BookHouse.Models.EF;
using BookHouse.Models.Entities;
using BookHouse.Models.ViewModel.SachViewmodel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Repositories
{
    public class SachRepository : ISachRepository
    {
        private readonly AppDBContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public SachRepository(AppDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public int Create(CreateViewModel sach, IFormFile[] image)
        {
            var cresach = context.Sachs.FirstOrDefault(e => e.TenSach == sach.TenSach && e.DanhMucId == sach.DanhMucId);
            if (sach != null && cresach == null)
            {
                var newbook = new Sach()
                {

                    TenSach = sach.TenSach,
                    TacGia = sach.TacGia,
                    NXB = sach.NXB,
                    NgayXuatBan = sach.NgayXuatBan,
                    TomTatSach = sach.TomTatSach,
                    GiaSach = sach.GiaSach,
                    DanhMucId = sach.DanhMucId
                };
                var fileName = string.Empty;
                if (image != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{image[0].FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        image[0].CopyTo(fs);
                    }
                }
                newbook.AnhSach = fileName;
                context.Sachs.Add(newbook);
                return context.SaveChanges();
            }
            return -1;
        }

        public bool Delete(Sach sach)
        {
            throw new NotImplementedException();
        }

        public int Edit(Sach sach)
        {
            throw new NotImplementedException();
        }

        public int Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sach> GetAll(int? id)
        {
            throw new NotImplementedException();
        }
    }
}