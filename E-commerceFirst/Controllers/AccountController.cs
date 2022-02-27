using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_commerceFirst.Controllers
{

    [AllowAnonymous]
    public class AccountController : Controller
    {
        NewUserManager num = new NewUserManager(new EfNewUserRepository());


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(NewUser n)
        {
            Context x = new Context();
            var datavalue = x.NewUsers.FirstOrDefault(a => a.NewUserMail == n.NewUserMail && a.NewUserPassword == n.NewUserPassword);
            if (datavalue!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,n.NewUserMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "MainPage");
            }
            else
            {
                return View();
            }
        }

     

        [HttpGet]
        public IActionResult RegisterPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPage(NewUser n)
        {
            NewUserValidator validationRules = new NewUserValidator();
            ValidationResult result = validationRules.Validate(n);
            if (result.IsValid)
            {
                n.NewUserStatus = true;
                num.AddUser(n);

                return RedirectToAction("Index", "Account");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
