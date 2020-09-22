using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHouse.Models.EF;
using BookHouse.Models.Entities;
using BookHouse.Models.Repositories;
using BookHouse.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BookHouse.Controllers
{
    public class DanhMucSachController : Controller
    {
        private readonly IDanhMucSachRepository danhMucSachRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly AppDBContext context;

        public DanhMucSachController(IDanhMucSachRepository danhMucSachRepository, IWebHostEnvironment webHostEnvironment,AppDBContext context)
        {
            this.danhMucSachRepository = danhMucSachRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.context = context;
        }
        public IActionResult Index()
        {
            var danhmuc = context.DanhMucSachs.ToList();
            
            return View(danhmuc);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DanhMucSach danhMucSach)
        {
            if (ModelState.IsValid)
            {
                var danhmuc = new DanhMucSach()
                {
                    TenDanhMuc = danhMucSach.TenDanhMuc,
                    MoTa = danhMucSach.MoTa
                };
                context.DanhMucSachs.Add(danhmuc);
                context.SaveChanges();
                return RedirectToAction("Index", "DanhMucSach");
            }
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var danhmuc = context.DanhMucSachs.Find(id);
            return View(danhmuc);
        }
        [HttpPost]
        public IActionResult Edit(DanhMucSach danhmucSach)
        {
            var danhmuc = context.DanhMucSachs.FirstOrDefault(e => e.DanhMucSachId==danhmucSach.DanhMucSachId);
            if(danhmuc != null)
            {
                danhmuc.TenDanhMuc = danhmucSach.TenDanhMuc;
                danhmuc.MoTa = danhmucSach.MoTa;
                context.SaveChanges();
                return RedirectToAction("Index", "DanhMucSach");
            }         
            return View();
        }

      
        public IActionResult Delete (int id)
        {
            var result = danhMucSachRepository.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return Ok(!result);
        }

    }
}
