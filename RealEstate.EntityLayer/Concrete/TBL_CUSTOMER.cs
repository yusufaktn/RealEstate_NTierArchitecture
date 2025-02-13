using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_CUSTOMER
    {
        [Key]
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_SURNAME { get; set; }
        public string CUSTOMER_MAIL { get; set; }

        [StringLength(11)]
        public string CUSTOMER_PHONE { get; set; }

        public ICollection<TBL_COMMENT> TBL_COMMENTs { get; set; }


    }
}
