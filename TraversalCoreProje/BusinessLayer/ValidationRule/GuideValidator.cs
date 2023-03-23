using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz..");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklamasını giriniz..");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görseli seçiniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakterlik isim giriniz");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen en az 8 karakterlik isim giriniz");
        }
    }
}
