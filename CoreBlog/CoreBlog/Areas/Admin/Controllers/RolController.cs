﻿using CoreBlog.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin,Moderator")]
    [Authorize(Roles="Admin")]
    public class RolController : Controller
    {
        private readonly RoleManager<AppRole> _rolManager;
        private readonly UserManager<AppUser> _userManager;
        public RolController(RoleManager<AppRole> rolManager,UserManager<AppUser> userManager)
        {
            _rolManager = rolManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _rolManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole()
                {
                    Name = model.Name
                };
                var result = await _rolManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _rolManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                ID = values.Id,
                Name = values.Name,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var values = _rolManager.Roles.Where(x => x.Id == model.ID).FirstOrDefault();
            values.Name = model.Name;
            var result = await _rolManager.UpdateAsync(values);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _rolManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _rolManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult UserRoleList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _rolManager.Roles.ToList();
            TempData["UserID"] = user.Id;

            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach(var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleID = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userID = (int)TempData["UserID"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userID);
            foreach(var item in model)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList");
        }
    }
}
