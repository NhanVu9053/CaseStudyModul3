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
        private readonly AppDBContext context;
        private readonly ISachRepository sachRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public SachController(AppDBContext context, ISachRepository sachRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.sachRepository = sachRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
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
    }
}
