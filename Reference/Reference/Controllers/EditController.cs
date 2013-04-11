using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reference.Models;
using Reference.Repository;

namespace Reference.Controllers
{
    public class EditController : Controller
    {
        //
        // GET: /Edit/

        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(string Sid)
        {
            //ViewBag.Age = 66;
            return View();
        }
        
       
        public JsonResult GetStudentInfo(int? Sid)
        {
            TestEntities context = new TestEntities();
            Repository.Student StudentInfo = context.Students.Where(s => s.StudentID == Sid).SingleOrDefault();
            ViewBag.Age = StudentInfo.Age;
            return Json(StudentInfo, JsonRequestBehavior.AllowGet);
        }
        
    }
}
