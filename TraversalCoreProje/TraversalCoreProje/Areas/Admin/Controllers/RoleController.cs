using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        [Route("CreateRole")]

        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateRole")]

        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRole)
        {
            AppRole role = new AppRole()
            {
                Name = createRole.RoleName
            };
            var result= await _roleManager.CreateAsync(role);
            if(result.Succeeded)
            {
                return RedirectToAction("Index"); ;
            }
            else
            {
                return View();

            }
        }

        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateRole/{id}")]
        public IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRole = new UpdateRoleViewModel()
            {
                RoleID = value.Id,
                RoleName = value.Name
            };
            return View(updateRole);
        }

        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRole)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRole.RoleID);
            value.Name = updateRole.RoleName;
            var result= await _roleManager.UpdateAsync(value);

            if (result.Succeeded)
            {
                return RedirectToAction("Index"); ;
            }
            else
            {
                return View();

            }
        }
        [Route("UserList")]
        public IActionResult UserList() 
        { 
            var values= _userManager.Users.ToList();
            return View(values);
        }
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();   
            foreach (var role in roles)
            {
                RoleAssignViewModel model= new RoleAssignViewModel();
                model.RoleId = role.Id;
                model.RoleName = role.Name;
                model.RoleExist = userRoles.Contains(role.Name);
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            //var userid = Convert.ToInt32 (TempData["Userid"]); //bu yöntem de olur
            var userid = (int)TempData["userid"]; //burade parantez içindeki int, string değeri int e dönüştürdü. 
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach(var item in model)
            {
                if(item.RoleExist)  //RoleExist true ise
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }

    }
}
