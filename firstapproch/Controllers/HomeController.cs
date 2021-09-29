using firstapproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstapproch.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)

        {
            db.students.Add(s);
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.InsertMessage = "<script>alert('data inserted')</script>";
            }
            else
            {
                ViewBag.InsertMessage = "<script>alert('data not inserted')</script>";
            }
            return View();
        }
    }
}