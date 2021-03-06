﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reference.Repository;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult GetStudent()
        {
            StudentServiceClient client = new StudentServiceClient();
            Student student = client.GetStudent(Convert.ToString(17));
            return View();
        }
    }
}
