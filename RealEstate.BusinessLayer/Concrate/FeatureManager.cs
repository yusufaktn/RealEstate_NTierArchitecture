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
    public class FeatureManager:FeatureService
    {

        IFeatureDAL _featureDAL;
        public FeatureManager(IFeatureDAL featureDAL)
        {
            
            _featureDAL = featureDAL;
        }

        public void Delete(TBL_FEATURE t)
        {
            throw new NotImplementedException();
        }

        public TBL_FEATURE GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_FEATURE> GetList()
        {
            return _featureDAL.GetList();
        }

        public void Insert(TBL_FEATURE t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_FEATURE t)
        {
            throw new NotImplementedException();
        }
    }
}
