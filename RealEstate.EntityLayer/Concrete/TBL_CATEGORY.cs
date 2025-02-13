using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_CATEGORY
    {
        [Key]
        public int CATEGORY_ID { get; set; }
        public string CATEGORY_NAME { get; set; }

        [StringLength(1000)]
        public string CATEGORY_DETAILS { get; set; }

        public bool CATEGORY_STATUS { get; set; }

        public ICollection<TBL_PRODUCT> TBL_PRODUCTs { get; set; }

    }
}
