using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StellerAcunMedyaAkademiPortfolio.Models;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        StellerAcunMedyaDbEntities db=new StellerAcunMedyaDbEntities();
        public ActionResult Index()
        {
            var values=db.TblTestimonial.ToList();
            return View(values);
        }

        public ActionResult DeleteReference(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(TblTestimonial testimonial)
        {
            db.TblTestimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}