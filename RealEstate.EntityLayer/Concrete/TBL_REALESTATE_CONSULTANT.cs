using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Concrete
{
    public class TBL_REALESTATE_CONSULTANT
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string NAME{ get; set; }
        [StringLength(50)]
        public string SURNAME { get; set; }
        [StringLength(50)]
        public string PHONE { get; set; }
        [StringLength(80)]
        public string EMAIL { get; set; }
        [StringLength(350)]
        public string DETAIL{ get; set; }
        [StringLength(100)]
        public string SPECIALIZATION{ get; set; }
        [StringLength(250)]
        public string IMAGE { get; set; }
        //  Bu tabloya rating kısmı eklencek ve ayrı tablo oluşturulup hangi kullanıcı hangi danışmana yorum yapmış puan vermiş eşleştirilecek. 


    }
}
