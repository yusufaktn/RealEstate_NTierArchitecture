using FluentValidation;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.BusinessLayer.ValidationRules
{
    public class ConsultantValidator: AbstractValidator<TBL_REALESTATE_CONSULTANT>
    {
        public ConsultantValidator()
        {
            //Empty
            RuleFor(x => x.NAME).NotEmpty().WithMessage(" Ad Boş Geçilemez!!");
            RuleFor(x => x.SURNAME).NotEmpty().WithMessage("Soyad Boş Geçilemez!!");
            RuleFor(x => x.PHONE).NotEmpty().WithMessage("Telefon Boş Geçilemez!!");
            RuleFor(x => x.EMAIL).NotEmpty().WithMessage("Email Boş Geçilemez!!");
            RuleFor(x => x.DETAIL).NotEmpty().WithMessage("Detay Boş Geçilemez!!");
            RuleFor(x => x.SPECIALIZATION).NotEmpty().WithMessage("Uzmanlık Boş Geçilemez!!");
            RuleFor(x => x.IMAGE).NotEmpty().WithMessage("Fotoğraf alanı boş geçilemez.");

            //Min
            RuleFor(x => x.NAME).MinimumLength(5).WithMessage(" Adı En Az 5 Karakter Olmalıdır");
            RuleFor(x => x.SURNAME).MinimumLength(2).WithMessage(" Soyadı En Az 2 Karakter Olmalıdır");
            RuleFor(x => x.PHONE).MinimumLength(11).WithMessage("Lütfen Başında 0 Olacak Şekilde 11 Haneli Yazın");
            RuleFor(x => x.DETAIL).MinimumLength(20).WithMessage("Hakkında Kısmı En Az 20 Karakter Olmalıdır");
            RuleFor(x => x.SPECIALIZATION).MinimumLength(3).WithMessage("Uzmanlık Adı En Az 3 Karakter Olmalıdır");


            //Max
            RuleFor(x => x.NAME).MaximumLength(50).WithMessage(" Adı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.SURNAME).MaximumLength(50).WithMessage("Soyadı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.PHONE).MaximumLength(11).WithMessage("Lütfen Başında 0 Olacak Şekilde 11 Haneli Yazın");
            RuleFor(x => x.EMAIL).MaximumLength(50).WithMessage("Mail En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.DETAIL).MaximumLength(350).WithMessage("Hakkında Alanı En Fazla 350 Karakter Olmalıdır");
            RuleFor(x => x.SPECIALIZATION).MaximumLength(50).WithMessage("Uzmanlık Adı En Fazla 50 Karakter Olmalıdır");
            //Email
            RuleFor(x => x.EMAIL).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Adresi Giriniz");

            




        }
    }
}
