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
    public class AdminConsultantController : Controller
    {
        ConsultantManager consultantManager = new ConsultantManager(new EfConsultantDAL());

        public ActionResult Index()
        {
            var consultant = new RealEstateViewModel()
            {
                Consultant = consultantManager.GetList()
            };
            return View(consultant);
        }

        [HttpGet]
        public ActionResult AddConsultant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddConsultant(TBL_REALESTATE_CONSULTANT p)
        {
            ConsultantValidator c_validation = new ConsultantValidator();
            ValidationResult result = c_validation.Validate(p);

            if (result.IsValid)
            {
                consultantManager.Insert(p);
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
        public ActionResult UpdateConsultant(int id)
        {
            var consultant = consultantManager.GetByID(id);
            return View(consultant);
        }


        [HttpPost]
        public ActionResult UpdateConsultant(TBL_REALESTATE_CONSULTANT p)
        {
            ConsultantValidator c_validation = new ConsultantValidator();
            ValidationResult result = c_validation.Validate(p);

            if (result.IsValid)
            {
                consultantManager.Update(p);
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



        public ActionResult GetProfile(int id)
        {

            var getprofile = new RealEstateViewModel
            {
                Consultant_GetID = consultantManager.GetByID(id)
            }; 

            return View(getprofile);

        }





    }
}