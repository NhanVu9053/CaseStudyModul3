using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookHouse.Models.EF;
using BookHouse.Models.Users;
using BookHouse.Models.ViewModel.RoleViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookHouse.Controllers
{
    public class RoleManagerController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDBContext context;

        public RoleManagerController(RoleManager<IdentityRole> roleManager,AppDBContext context)
        {
            this.roleManager = roleManager;
            this.context = context;
        }
        public IActionResult Index()
        {
            var roles = roleManager.Roles;
            var model = new List<Role>();
            model = roles.Select(r => new Role
            {
                RoleId = r.Id,
                TenVaiTro = r.Name
            }).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await roleManager.CreateAsync(new IdentityRole
                {
                    Name = model.TenVaiTro
                });
                if (result.Succeeded)
                    return RedirectToAction("Index", "RoleManager");
                foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var model = new RoleEditViewModel
                {
                    RoleId = role.Id,
                    TenVaiTro = role.Name
                };
                ViewBag.UsersCount = (from u in context.Users
                                      join r in context.UserRoles on u.Id equals r.UserId
                                      where r.RoleId == id
                                      select u).ToList().Count;
                return View(model);
            }

            return View("~/Views/Error/PageNotFound.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(model.RoleId);
                if (role != null)
                {
                    role.Name = model.TenVaiTro;
                    var result = await roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                        return RedirectToAction("index", "RoleManager");
                    foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }
        public async Task<IActionResult> Delete(string id)
        {
            var delRole = await roleManager.FindByIdAsync(id);
            if (delRole != null)
            {
                var usersCount = (from u in context.Users
                                  join r in context.UserRoles on u.Id equals r.UserId
                                  where r.RoleId == id
                                  select u).ToList().Count;
                if (usersCount == 0)
                {
                    var result = await roleManager.DeleteAsync(delRole);
                    if (result.Succeeded) return RedirectToAction("Index", "RoleManager");
                }
            }

            return View("~/Views/Error/PageNotFound.cshtml");
        }
    }
}
