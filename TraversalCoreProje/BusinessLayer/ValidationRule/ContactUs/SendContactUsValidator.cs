using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmalısınız.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter veri girişi yapabilirsiniz.");
            RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("Mesaj alanına en az 5 karakter veri girişi yapabilirsiniz.");
            RuleFor(x => x.MessageBody).MaximumLength(100).WithMessage("Mesaj alanına en fazla 100 karakter veri girişi yapabilirsiniz.");
        }
    }
}
