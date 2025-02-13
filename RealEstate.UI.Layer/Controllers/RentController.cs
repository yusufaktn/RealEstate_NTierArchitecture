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
    public class RentController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDAL());
        Product_FeatureManager product_Feature = new Product_FeatureManager(new EfProductFeatureDAL());

        public ActionResult Index()
        {
            var viewmodel = new RealEstateViewModel
            {
                Products = productManager.GetTypeProduct(1),
                Product_Features = ProductFeature()
            };
            return View(viewmodel);
        }
       
        private List<TBL_PRODUCT_FEATURES> ProductFeature()
        {
            return  product_Feature.GetList();
        }
        


    }
}