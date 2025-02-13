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
    public class OpportunityManager : OpportunityService
    {
        IOpportunityDAL _opportunityDAL;

        public OpportunityManager(IOpportunityDAL opportunityDAL)
        {
            _opportunityDAL = opportunityDAL;
        }


        public void Delete(TBL_OPPORTUNITY t)
        {
            throw new NotImplementedException();
        }

        public TBL_OPPORTUNITY GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_OPPORTUNITY> GetList()
        {
            return _opportunityDAL.GetList();
        }

        public void Insert(TBL_OPPORTUNITY t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_OPPORTUNITY t)
        {
            throw new NotImplementedException();
        }
    }
}
