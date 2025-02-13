using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_TYPE
    {
        [Key]
        public int TYPE_ID { get; set; }

        [StringLength(50)]
        public string  TYPE_NAME { get; set; }

        public ICollection<TBL_PRODUCT> TBL_PRODUCTs { get; set; }

    }
}
