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
    public class CategoryManager:CategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;

        }

        public void Insert(TBL_CATEGORY t)
        {
            _categoryDAL.Insert(t);

        }

        public void Update(TBL_CATEGORY t)
        {
            _categoryDAL.Update(t);
        }

        public void Delete(TBL_CATEGORY t)
        {
             _categoryDAL.Delete(t);
        }

        public List<TBL_CATEGORY> GetList()
        {        

            return _categoryDAL.GetList();
        }

        public TBL_CATEGORY GetByID(int id)
        {
            return _categoryDAL.GetByID(x => x.CATEGORY_ID == id);
        }
    }
}
