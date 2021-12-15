using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidation:AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(1500);
            RuleFor(c => c.Descriptions).NotEmpty();
            RuleFor(c => c.Descriptions).MinimumLength(2);
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();

        }
    }
}
