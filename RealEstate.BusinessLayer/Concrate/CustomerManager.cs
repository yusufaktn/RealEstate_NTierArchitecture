using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.Concrate
{
    public class CustomerManager : CustomerService
    {
        ICustomerDAL _customerDaL;

        public CustomerManager(ICustomerDAL customerDaL)
        {
            _customerDaL = customerDaL;
        }

        public void Delete(TBL_CUSTOMER t)
        {
            throw new NotImplementedException();
        }

        public TBL_CUSTOMER GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_CUSTOMER> GetList()
        {
            return _customerDaL.GetList();
        }

        public void Insert(TBL_CUSTOMER t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_CUSTOMER t)
        {
            throw new NotImplementedException();
        }
    }
}
