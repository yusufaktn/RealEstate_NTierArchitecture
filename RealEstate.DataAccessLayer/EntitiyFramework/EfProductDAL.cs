using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.DataAccessLayer.Repository;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Web;


namespace RealEstate.UI.Layer.EntitiyFramework
{
    public class EfProductDAL : GenericRepository<TBL_PRODUCT>, IProductDAL
    {
        
    }
}