using RealEstate.BusinessLayer.Concrate;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.UI.Layer.Controllers
{
    public class ContactController : Controller
    {
        
        ContactManager contactManager = new ContactManager(new EfContactDAL());


        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactPush(TBL_CONTACT p)
        {
            p.DATE = DateTime.Parse(DateTime.Now.ToShortDateString());
            contactManager.Insert(p);
            return RedirectToAction("Index", "Home");
        }


    }
}