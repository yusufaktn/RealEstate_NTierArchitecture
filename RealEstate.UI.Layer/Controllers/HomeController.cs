using RealEstate.BusinessLayer.Concrate;
using RealEstate.DataAccessLayer.EntitiyFramework;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;
using RealEstate.UI.Layer.EntitiyFramework;
using RealEstate.UI.Layer.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace RealEstate.UI.Layer.Controllers
{
    public class HomeController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDAL());
        ProductManager pm = new ProductManager(new EfProductDAL());
        Product_FeatureManager p_f = new Product_FeatureManager(new EfProductFeatureDAL());
        FeatureManager fm = new FeatureManager(new EfFeatureDAL());
        SlıderManager sm = new SlıderManager(new EfSliderDAL());
        OpportunityManager om = new OpportunityManager(new EfOpportunityDAL());




        public ActionResult Index()
        {

            var viewModel = new RealEstateViewModel
            {
                Comments = GetComments(),
                Products = GetProducts(),
                Features = GetFeature(),
                Product_Features = GetProductFeatures(),
                Sliders = GetSLIDERs(),
                Opportunity = GetOpportunity()

            };

            return View(viewModel);
        }
        private List<TBL_COMMENT> GetComments()
        {
            return cm.GetList();
        }

        private List<TBL_PRODUCT> GetProducts() 
        {
        
            return pm.GetList();

        }

        private List<TBL_FEATURE> GetFeature()
        {

            return fm.GetList();
        }

        private List<TBL_PRODUCT_FEATURES> GetProductFeatures()
        {
            return p_f.GetList();
        }

        private List<TBL_SLIDER> GetSLIDERs()
        {
            return sm.GetListBL();
        }

        private List<TBL_OPPORTUNITY> GetOpportunity()
        {
            return om.GetList();
        }





    }
}