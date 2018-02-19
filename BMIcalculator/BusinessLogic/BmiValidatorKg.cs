using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMIcalculator.Models;
using FluentValidation;

namespace BMIcalculator.BusinessLogic
{
    public class BmiValidatorKg : AbstractValidator<BMI>
    {
        public BmiValidatorKg()
        {
            RuleFor(x => x.Weight).NotEmpty().WithMessage("Field Weight fdsfds can not be empty").LessThan(1000).WithMessage("You weight over 1000 kg??");
            RuleFor(model => model.Height).NotEmpty().WithMessage("Field Heightfdsfsd  can not be empty").LessThan(260)
                .WithMessage("Aren't you too tall ??");

        }

    }
}