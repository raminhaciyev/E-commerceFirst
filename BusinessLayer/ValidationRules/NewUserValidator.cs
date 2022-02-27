using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class NewUserValidator: AbstractValidator<NewUser>
    {
        public NewUserValidator()
        {
            RuleFor(x => x.NewUserName).NotEmpty().WithMessage("Məlumatları doldurun.");
            RuleFor(x => x.NewUserSurname).NotEmpty().WithMessage("Məlumatları doldurun.");
            RuleFor(x => x.NewUserMail).NotEmpty().WithMessage("Məlumatları doldurun.");
            RuleFor(x => x.NewUserPhoneNumber).NotEmpty().WithMessage("Məlumatları doldurun.");
            RuleFor(x => x.NewUserPassword).NotEmpty().WithMessage("Məlumatları doldurun.");   
            RuleFor(x => x.NewUserName).MinimumLength(3).WithMessage("Minimum 3 hərfdən istifadə edə bilərsiniz.");   
            RuleFor(x => x.NewUserName).MaximumLength(30).WithMessage("Maksimum 30 hərfdən istifadə edə bilərsiniz.");   
            RuleFor(x => x.NewUserPassword).MaximumLength(30).WithMessage("Maksimum 30 xarakterli şifrə istifadə edə bilərsiniz.");   
            RuleFor(x => x.NewUserPassword).MinimumLength(5).WithMessage("Minimum 5 xarakterli şifrə istifadə edə bilərsiniz.");   
        }
    }
}
