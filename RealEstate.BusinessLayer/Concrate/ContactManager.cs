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
    public class ContactManager : ContactService
    {
        IContactDAL _contactDAL;
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }


        public void Delete(TBL_CONTACT t)
        {
            throw new NotImplementedException();
        }

        public TBL_CONTACT GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_CONTACT> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(TBL_CONTACT t)
        {
            _contactDAL.Insert(t);
        }

        public void Update(TBL_CONTACT t)
        {
            throw new NotImplementedException();
        }
    }
}
