using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Concrate
{
    public class Product_FeatureManager:Product_FeaturesService
    {
        IProduct_FeatureDAL product_FeatureDAL;

        public Product_FeatureManager(IProduct_FeatureDAL product_Feature)
        {
            product_FeatureDAL = product_Feature;

        }

        public void Delete(TBL_PRODUCT_FEATURES t)
        {
            throw new NotImplementedException();
        }

        public TBL_PRODUCT_FEATURES GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_PRODUCT_FEATURES> GetList()
        {
            return product_FeatureDAL.GetList();
        }

        public void Insert(TBL_PRODUCT_FEATURES t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_PRODUCT_FEATURES t)
        {
            throw new NotImplementedException();
        }
    }
}
