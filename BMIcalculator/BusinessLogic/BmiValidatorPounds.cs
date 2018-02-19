using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMIcalculator.Models;
using FluentValidation;

namespace BMIcalculator.BusinessLogic
{
    public class BmiValidatorPounds : AbstractValidator<BMI>
    {
        public BmiValidatorPounds()
        {
            RuleFor(model => model.Weight).NotEmpty().WithMessage("Field Weight can not be empty").LessThan(1000).WithMessage("You weight over 1000 kg??");
            RuleFor(model => model.Height).NotEmpty().WithMessage("Field Height can not be empty").LessThan(260)
                .WithMessage("Aren't you too tall ??");
            RuleFor(x => x.Enumerator).NotEmpty().WithMessage("Choose units - metric or british");

        }
    }
}