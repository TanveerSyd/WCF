using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reference.Repository;
using Reference.ViewModels;

namespace Reference.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            TestEntities context = new TestEntities();
            StudentViewModel viewModel = new StudentViewModel
            {
                Students = context.Students

            };

            return View(viewModel);
        }
        [HttpPost]
        public PartialViewResult Index(StudentViewModel vm)
        {
            TestEntities context = new TestEntities();
            context.Students.Add(vm.newStudent);
            context.SaveChanges();

            return PartialView("_StudentListControl",context.Students);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
