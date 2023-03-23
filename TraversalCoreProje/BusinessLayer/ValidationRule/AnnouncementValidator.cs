using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin.");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin.");
            RuleFor(x=>x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalıdır.");
            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter olmalıdır.");
            RuleFor(x=>x.Content).MinimumLength(10).WithMessage("Duyuru içeriği en az 10 karakter olmalıdır.");
            RuleFor(x=>x.Content).MaximumLength(500).WithMessage("Duyuru içeriği en fazla 500 karakter olmalıdır.");
        }
    }
}
