using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu Alan Boş Geçilemez !");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Bu Alanı Boş Geçilemez !");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu Alan Boş Geçilemez !");

            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Bu Alanın Karakter Sınırı 1500 !"); 
        }
    }
}
