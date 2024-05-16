using FluentValidation;
using MailBox.DtoLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto> 
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrarı alanı boş geçilemez!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("30 karakterden fazla giriş yapılamaz!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("2 karakterden az giriş yapılamaz!");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler birbiriyle eşleşmiyor!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz!");
        }
    }
}
