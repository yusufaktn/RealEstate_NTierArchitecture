using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.EntitiyFramework
{
    public class EfCommentDAL:GenericRepository<TBL_COMMENT>,ICommentDAL
    {
    }
}
