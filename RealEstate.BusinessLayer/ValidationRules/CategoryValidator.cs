using FluentValidation;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<TBL_CATEGORY>
    {
        public CategoryValidator()
        {
            
            RuleFor(x => x.CATEGORY_NAME).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!!");
            RuleFor(x => x.CATEGORY_NAME).MinimumLength(3).WithMessage("Kategori Adı En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.CATEGORY_NAME).MaximumLength(50).WithMessage("Kategori Adı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.CATEGORY_DETAILS).NotEmpty().WithMessage("Kategori Detayları Boş Geçilemez!!");
            RuleFor(x => x.CATEGORY_DETAILS).MaximumLength(150).WithMessage("Kategori Adı En Fazla 150 Karakter Olmalıdır");
            RuleFor(x => x.CATEGORY_DETAILS).MinimumLength(10).WithMessage("Kategori Adı En Az 10 Karakter Olmalıdır");
            RuleFor(x => x.CATEGORY_STATUS).NotEmpty().WithMessage("Kategori Durum Boş Geçilemez");


        }



    }
}
