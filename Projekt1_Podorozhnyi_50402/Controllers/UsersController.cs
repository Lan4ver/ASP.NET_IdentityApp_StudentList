using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projekt1_Podorozhnyi_50402.Models;
using Projekt1_Podorozhnyi_50402.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Projekt1_Podorozhnyi_50402.Controllers
{
    public class UsersController : Controller
    {
        UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index() => View(_userManager.Users.ToList());

        //public IActionResult Create() => View();

        //[HttpPost]
        //public async Task<IActionResult> Create(CreateUserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = new User { Email = model.Email, UserName = model.Email, Year = model.Year };
        //        var result = await _userManager.CreateAsync(user, model.Password);
        //        if(result.Succeeded)
        //        {
        //            return RedirectToAction("Idex");
        //        }
        //        else
        //        {
        //            foreach(var error in result.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, error.Description);

        //            }
        //        }
        //    }
        //    return View(model);
        //}

        ////-----------------------------------------------------------------////

        //[HttpPost]
        //public async Task<IActionResult> Edit(EditUserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = await _userManager.FindByIdAsync(model.Id);
        //        if (user != null)
        //        {
        //            user.Email = model.Email;
        //            user.UserName = model.Email;
        //            user.Year = model.Year;

        //            var result = await _userManager.UpdateAsync(user);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index");
        //            }
        //            else
        //            {
        //                foreach (var error in result.Errors)
        //                {
        //                    ModelState.AddModelError(string.Empty, error.Description);
        //                }
        //            }
        //        }
        //    }
        //    return View(model);
        //}

        ////-----------------------------------------------------------------////

        public async Task<IActionResult> Open(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            OpenUserViewModel model = new OpenUserViewModel { Id = user.Id, Email = user.Email, Year = user.Year };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Open(OpenUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.Year = model.Year;                    
                }
            }
            return View(model);
        }
    }
}
