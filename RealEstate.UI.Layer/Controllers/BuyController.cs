using RealEstate.BusinessLayer.Concrate;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.EntityLayer.Concrete;
using RealEstate.UI.Layer.EntitiyFramework;
using RealEstate.UI.Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.UI.Layer.Controllers
{
    public class BuyController : Controller
    {

        ProductManager productManager = new ProductManager(new EfProductDAL());
        Product_FeatureManager featureManager = new Product_FeatureManager(new EfProductFeatureDAL());


        public ActionResult Index()
        {

            var viewmodel = new RealEstateViewModel
            {
                Products = productManager.GetTypeProduct(2),
                Product_Features = featureManager.GetList()
            };

            return View(viewmodel);
        }

        


    }
}