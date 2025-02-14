using FluentValidation.Results;
using RealEstate.BusinessLayer.Concrate;
using RealEstate.BusinessLayer.ValidationRules;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.EntityLayer.Concrete;
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
            return View();
        }


        [HttpPost]
        public ActionResult AddCustomer(TBL_CUSTOMER p)
        {
            CustomerValidation c_validation = new CustomerValidation();
            ValidationResult result = c_validation.Validate(p);

            if (result.IsValid)
            {
                cm.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return View();

        }


        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var consultant = cm.GetByID(id);
            return View(consultant);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(TBL_CUSTOMER p)
        {
            CustomerValidation c_validation = new CustomerValidation();
            ValidationResult result = c_validation.Validate(p);

            if (result.IsValid)
            {
                cm.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }

            return View();
        }










    }
}