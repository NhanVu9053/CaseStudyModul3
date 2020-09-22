using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHouse.Models.EF;
using BookHouse.Models.Entities;
using BookHouse.Models.Repositories;
using BookHouse.Models.ViewModel.SachViewmodel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookHouse.Controllers
{
    public class SachController : Controller
    {
      
        private readonly ISachRepository sachRepository;
       

        public SachController( ISachRepository sachRepository)
        {
         
            this.sachRepository = sachRepository;
            
        }
        public IActionResult Index()
        {
            var ressult = sachRepository.GetAll().ToList();
            return View(ressult.ToList());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateViewModel model, IFormFile[] ImageFiles)
        {
            if (ModelState.IsValid)
            {
                var result = sachRepository.Create(model, ImageFiles);
                if (result > 0)
                {
                    return RedirectToAction("Index", "Sach");
                }

            }
            ViewData["Message"] = "Sản phẩm đã tồn tại";
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sachs = sachRepository.GetAll().ToList();
            var editsach = sachs.FirstOrDefault(e => e.SachID == id);
            var creaSach = new Sach()
            {
                SachID = editsach.SachID,
                TenSach = editsach.TenSach,
                TacGia = editsach.TacGia,
                NXB = editsach.NXB,
                NgayXuatBan = editsach.NgayXuatBan,
                TomTatSach = editsach.TomTatSach,
                GiaSach = editsach.GiaSach,
                DanhMucId = editsach.DanhMucId,
                AnhSach = editsach.AnhSach
            };
            return View(creaSach);
        }
        [HttpPost]
        public IActionResult Edit(Sach model, IFormFile[] ImageFiles)
        {
            var result = sachRepository.Edit(model, ImageFiles);
            if (result > 0)
            {
                return RedirectToAction("Index", "Sach");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if(sachRepository.Delete(id))
            {
                return RedirectToAction("Index", "Sach");
            }
            return View();
        }
    }
}
