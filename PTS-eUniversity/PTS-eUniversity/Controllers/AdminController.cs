using PTS_eUniversity.Services;
using PTS_eUniversity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTS_eUniversity.Controllers
{
    public class AdminController : Controller
    {
        public AdminManager adminManager { get; private set; }

        // GET: Admin

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            var model = new AdminVM();

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(AdminVM model) 
        {
            adminManager = new AdminManager();

            adminManager.AddUser(model);

            return View();
        }

    }
}