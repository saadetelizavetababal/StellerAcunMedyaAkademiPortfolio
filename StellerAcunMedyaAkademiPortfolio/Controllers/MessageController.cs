using StellerAcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StellerAcunMedyaAkademiPortfolio.Controllers
{
    public class MessageController : Controller
    {
        StellerAcunMedyaDbEntities db=new StellerAcunMedyaDbEntities();
        // GET: Message
        public ActionResult Index()
        {
            var values=db.TblMessage.Where(x=>x.IsRead==false).ToList();
            return View(values);
        }

        public ActionResult MessageDetail(int id)
        {
            var message = db.TblMessage.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return View(message);
        }

        public ActionResult ReadMessages()
        {
            var values=db.TblMessage.Where(x=>x.IsRead==true).ToList();  
            return View(values);

        }

    }
}