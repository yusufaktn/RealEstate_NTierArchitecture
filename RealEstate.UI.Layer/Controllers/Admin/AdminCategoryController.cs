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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDAL());
        
        public ActionResult Index()
        {
            var category = new RealEstateViewModel
            {
                Categories = cm.GetList()
            };


            return View(category);
        }
         
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(TBL_CATEGORY p)
        {
            CategoryValidator category_calidator = new CategoryValidator();
            ValidationResult result = category_calidator.Validate(p);

            if(result.IsValid)
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

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = cm.GetByID(id);
            cm.Delete(categoryValue);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryValue = cm.GetByID(id);           
            return View(categoryValue);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TBL_CATEGORY p)
        {
            cm.Update(p);
            return RedirectToAction("Index");

        }

        




    }
}