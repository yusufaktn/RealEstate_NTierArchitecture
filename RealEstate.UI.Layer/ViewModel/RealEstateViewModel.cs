using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstate.UI.Layer.ViewModel
{
    public class RealEstateViewModel
    {

        public List<TBL_COMMENT> Comments { get; set; }
        public List<TBL_CATEGORY> Categories { get; set; }
        public List<TBL_CONTACT> Contacts { get; set; }
        public List<TBL_FEATURE> Features { get; set; }
        public List<TBL_PRODUCT> Products { get; set; }
        public List<TBL_SLIDER> Sliders { get; set; }
        public List<TBL_TYPE> Types { get; set; }
        public List<TBL_PRODUCT_FEATURES> Product_Features { get; set; }
        public List<TBL_CUSTOMER> Customers { get; set; }
        public List<TBL_OPPORTUNITY> Opportunity { get; set; }
        public List<TBL_REALESTATE_CONSULTANT> Consultant { get; set; }
       
        //ID ye göre sonuç almak istediğimde aşağıdakileri kullanıyorum çünkü List türünde bir değere ihtiyacım olmuyor.
        //Ayrıca List olarak çağırdığımda döngü olmadan tabloların değerlerine ulaşamıyorum.
        public TBL_REALESTATE_CONSULTANT Consultant_GetID { get; set; }



    }
}