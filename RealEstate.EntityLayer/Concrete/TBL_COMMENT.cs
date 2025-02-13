using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_COMMENT
    {
        [Key]
        public int COMMENT_ID { get; set; }

        [StringLength(1000)]
        public string COMMENT_DESCRIPTION { get; set; }

        public DateTime COMMENT_DATE { get; set; }

        public int CUSTOMER_ID { get; set; }
        public virtual TBL_CUSTOMER TBL_CUSTOMER { get; set; }
    }
}
