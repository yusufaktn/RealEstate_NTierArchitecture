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
    public class ProductsController : Controller
    {

        ProductManager productManager = new ProductManager(new EfProductDAL());
        Product_FeatureManager product_Feature = new Product_FeatureManager(new EfProductFeatureDAL());


        public ActionResult Index()
        {
            
            var viewmodel = new RealEstateViewModel
            {
                Products = ProductGet(),
                Product_Features =ProductGetFeatures()

            };
            return View(viewmodel);
        }


        private List<TBL_PRODUCT> ProductGet()
        {
            return productManager.GetList();
        }

        private List<TBL_PRODUCT_FEATURES> ProductGetFeatures()
        {
            return product_Feature.GetList();
        }





    }
}