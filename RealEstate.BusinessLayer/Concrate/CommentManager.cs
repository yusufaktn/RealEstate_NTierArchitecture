using RealEstate.BusinessLayer.Abstract;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RealEstate.BusinessLayer.Concrate
{
    public class CommentManager : CommentService
    {
        ICommentDAL _commentDAl;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAl = commentDAL;
        }
        public void Delete(TBL_COMMENT t)
        {
            throw new NotImplementedException();
        }

        public TBL_COMMENT GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TBL_COMMENT> GetList()
        {
           return _commentDAl.GetList();
        }

        public void Insert(TBL_COMMENT t)
        {
            throw new NotImplementedException();
        }

        public void Update(TBL_COMMENT t)
        {
            throw new NotImplementedException();
        }
    }
}
