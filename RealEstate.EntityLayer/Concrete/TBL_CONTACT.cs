using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_CONTACT
    {
        [Key]
        public int CONTACT_ID { get; set; }
        public string NAME { get; set; }
        public string MAIL { get; set; }

        [StringLength(500)]
        public string MESSAGE { get; set; }
        public DateTime DATE { get; set; }        



    }
}
