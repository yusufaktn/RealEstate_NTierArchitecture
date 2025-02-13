using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_OPPORTUNITY
    {
        [Key]
        public int OPPORTUNITY_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public virtual TBL_PRODUCT TBL_PRODUCT { get; set; }




    }
}
