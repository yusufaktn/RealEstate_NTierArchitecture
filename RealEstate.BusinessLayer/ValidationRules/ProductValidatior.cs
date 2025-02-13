using FluentValidation;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.ValidationRules
{
    public class ProductValidatior: AbstractValidator<TBL_PRODUCT>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.PRODUCT_TITLE).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            RuleFor(x => x.PRODUCT_DESCRIPTION).MinimumLength(20).WithMessage("Ürün Adı En Az 20 Karakter Olmalıdır");
            RuleFor(x=> x.PRODUCT_DESCRIPTION).MaximumLength(100).WithMessage("Ürün Adı En Fazla 100 Karakter Olmalıdır");

        }
    }
}
