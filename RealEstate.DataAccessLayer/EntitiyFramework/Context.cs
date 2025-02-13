using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RealEstate.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<TBL_CATEGORY> TBL_CATEGORies { get; set; }
        public DbSet<TBL_PRODUCT> TBL_PRODUCTs { get; set; }
        public DbSet<TBL_CUSTOMER> TBL_CUSTOMERs { get; set; }
        public DbSet<TBL_COMMENT> TBL_COMMENTs { get; set; }
        public DbSet<TBL_CONTACT> TBL_CONTACTs { get; set; }
        public DbSet<TBL_TYPE> TBL_TYPEs { get; set; }
        public DbSet<TBL_SLIDER> TBL_SLIDERs { get; set; }
        public DbSet<TBL_FEATURE> TBL_FEATUREs { get; set; }
        public DbSet<TBL_PRODUCT_FEATURES> TBL_PRODUCT_FEATURESs { get; set; }
        public DbSet<TBL_OPPORTUNITY> TBL_OPPORTUNITies { get; set; }
        public DbSet <TBL_REALESTATE_CONSULTANT> TBL_REALESTATE_CONSULTANTs { get; set; }
    }
}
