using RealEstate.BusinessLayer.Concrate;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.UI.Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.UI.Layer.Controllers.Admin
{
    public class AdminCustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerDAL());
        // GET: AdminCustomer
        public ActionResult Index()
        {
            var customer = new RealEstateViewModel
            {
                Customers = cm.GetList()
            };

            return View(customer);
        }


        [HttpGet]
        public ActionResult AddCustomer()
        {

        }







    }
}