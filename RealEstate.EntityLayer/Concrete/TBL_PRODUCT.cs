using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_PRODUCT
    {
        [Key]
        public int PRODUCT_ID { get; set; }
        public decimal PRODUCT_PRICE { get; set; }

        [StringLength(100)]
        public string PRODUCT_TITLE { get; set; }

        [StringLength(50)]
        public string PRODUCT_SIZE { get; set; }

        [StringLength(108)]
        public string PRODUCT_DESCRIPTION { get; set; }

        public string PRODUCT_IMAGE { get; set; }

        public int TYPE_ID { get; set; }
        public virtual TBL_TYPE TBL_TYPE { get; set; }

        public int CATEGORY_ID { get; set; }
        public virtual TBL_CATEGORY TBL_CATEGORY { get; set; }


        public ICollection<TBL_SLIDER> TBL_SLIDERs { get; set; }
        public ICollection<TBL_OPPORTUNITY> TBL_OPPORTUNITYs { get; set; }
    }
}
