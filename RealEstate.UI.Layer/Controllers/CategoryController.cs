using RealEstate.BusinessLayer.Concrate;
using RealEstate.BusinessLayer.ValidationRules;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace RealEstate.UI.Layer.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryDAL());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCategory(TBL_CATEGORY p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult validationResult = categoryValidator.Validate(p);

            if(validationResult.IsValid)
            {
                cm.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return RedirectToAction("Index");


        }




    }
}