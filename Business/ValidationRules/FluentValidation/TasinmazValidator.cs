using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TasinmazValidator : AbstractValidator<Tasinmaz>
    {
        public TasinmazValidator()
        {
            RuleFor(p => p.IlceId).NotEmpty();
            RuleFor(p => p.TasinmazId).NotEmpty();
            RuleFor(p => p.IlId).NotEmpty();
            RuleFor(p => p.TasinmazAdi).NotEmpty();
            RuleFor(p => p.TasinmazAdi).MinimumLength(2);
            //RuleFor(p => p.TasinmazAdi).Must(StartWithA).WithMessage("Tasinmazlar A harfi ile başlamadılır");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
