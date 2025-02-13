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
    public class ConsultantManager : ConsultantService
    {
        IConsultantDAL _consultant;
        public ConsultantManager(IConsultantDAL consultant)
        {
            _consultant = consultant;
        }

        public void Delete(TBL_REALESTATE_CONSULTANT t)
        {
             _consultant.Delete(t);
        }

        public TBL_REALESTATE_CONSULTANT GetByID(int id)
        {
            return _consultant.GetByID(x=>x.ID==id);
        }

        public List<TBL_REALESTATE_CONSULTANT> GetList()
        {
            return _consultant.GetList();
        }

        public void Insert(TBL_REALESTATE_CONSULTANT t)
        {
            _consultant.Insert(t);
        }

        public void Update(TBL_REALESTATE_CONSULTANT t)
        {
            _consultant.Update(t);
        }
    }
}
