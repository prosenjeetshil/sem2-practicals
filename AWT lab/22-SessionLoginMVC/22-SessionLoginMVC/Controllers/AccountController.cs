using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _22_SessionLoginMVC.Models;

namespace _22_SessionLoginMVC.Controllers
{
    public class AccountController : Controller
    {
        // Simulated user database
        private List<User> users = new List<User>
        {
            new User { Username = "testuser", Password = "password123" },
            new User { Username = "prosenjeet", Password = "viki123" }
        };

        // GET: Login Page
        public ActionResult Login()
        {
            return View();
        }

        // POST: Handle Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Session["Username"] = username; // Store user session
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }

        // GET: Dashboard Page
        public ActionResult Dashboard()
        {
            if (Session["Username"] == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.Username = Session["Username"].ToString();
            return View();
        }

        // Logout method
        public ActionResult Logout()
        {
            Session.Clear(); // Clear session
            return RedirectToAction("Login");
        }
    }
}