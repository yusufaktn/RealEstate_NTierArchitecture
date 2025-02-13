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
    public class SlıderManager:SliderService
    {
        ISlıderDAL _slıderDAL;

        public SlıderManager(ISlıderDAL slıderDAL)
        {
            _slıderDAL = slıderDAL;
        }

        public void Delete(TBL_SLIDER t)
        {
            throw new NotImplementedException();
        }

        public TBL_SLIDER GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_SLIDER> GetList()
        {
            throw new NotImplementedException();
        }

        public List<TBL_SLIDER> GetListBL()
        {
            return _slıderDAL.GetList();
        }

        public void Insert(TBL_SLIDER t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_SLIDER t)
        {
            throw new NotImplementedException();
        }
    }
}
