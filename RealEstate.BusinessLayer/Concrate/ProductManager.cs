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
    public class ProductManager : ProductService
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Delete(TBL_PRODUCT t)
        {
            throw new NotImplementedException();
        }

        public List<TBL_PRODUCT> GetBuyProduct(int id)
        {
            throw new NotImplementedException();
        }

        public TBL_PRODUCT GetByID(int id)
        {
            return _productDAL.GetByID(x=>x.CATEGORY_ID==id);
        }

        public List<TBL_PRODUCT> GetList()  
        {
            return _productDAL.GetList();
        }

        public List<TBL_PRODUCT> GetTypeProduct(int id)
        {
            return _productDAL.List(x => x.TYPE_ID == id);

        }

        public void Insert(TBL_PRODUCT t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_PRODUCT t)
        {
            throw new NotImplementedException();
        }
    }
}
