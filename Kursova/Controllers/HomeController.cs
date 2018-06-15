using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kursova.Models;


namespace Kursova.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UserName= User.Identity.Name.ToString();
            return View();
        }
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string filter)
        {
            ViewBag.filter = filter;
            return View();
        }
        public ActionResult GetProgrammers(string filter = null)
        {
            List<Professor> prof = new List<Professor>();
            if (filter != null)
            {
                using (ProfessorContext db = new ProfessorContext())
                {
                    foreach (Professor p in db.Professors)
                    {
                        if (p.Name.Contains(filter))
                        {
                            prof.Add(p);
                        }
                    }
                }
            }
            return View("_TableProgrammers", prof);
        }
            
            
        //[HttpGet]
        //[AllowAnonymous]
        //public ActionResult Search(string names)
        //{
        //    List<Professor> prof = new List<Professor>();
        //    using (ProfessorContext db = new ProfessorContext())
        //    {
        //        foreach(Professor p in db.Professors)
        //        {
        //            if (p.Name.Contains(names))
        //            {
        //                prof.Add(p);
        //            }
        //        }
        //    }
        //    ViewBag.prof = prof;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Search(string name)
        //{
        //    using (ProfessorContext db = new ProfessorContext())
        //    {
        //        var prof = db.Professors.Where(a => a.Name.Contains(name)).ToList();
        //        if (prof.Count <= 0)
        //        {
        //           // return HttpNotFound();
        //        }
        //        return PartialView(prof);
        //    }
        //}


    }
}