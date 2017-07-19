﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BeautyCenterCore.Models;
using Microsoft.AspNetCore.Http;

namespace BeautyCenterCore.Controllers
{
    public class HomeController : Controller
    {
        private BeautyCoreDb _context;
        public HomeController(BeautyCoreDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.userAccount.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount user)
        {
            if (ModelState.IsValid)
            {
                _context.userAccount.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + " is successfully registered.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            var account = _context.userAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong.");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View();
        //}
        //private readonly UserManager<ApplicationUser> userManager;

        //public HomeController(UserManager<ApplicationUser> userManager)
        //{
        //    this.userManager = userManager;
        //}
        //[Authorize(Roles = "User")]
        //public IActionResult Index()
        //{
        //    string userName = userManager.GetUserName(User);
        //    return View("Index", userName);
        //}
    }
}
