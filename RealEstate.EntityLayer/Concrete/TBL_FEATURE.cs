using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_FEATURE
    {
        [Key]
        public int FEATURE_ID { get; set; }
        [StringLength(100)]
        public string FEATURE_NAME { get; set; }

        public ICollection<TBL_PRODUCT_FEATURES> TBL_PRODUCT_FEATURES { get; set; }
    }
}
