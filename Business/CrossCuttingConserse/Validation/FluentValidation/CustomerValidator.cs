using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConserse.Validation.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).Must(IsStartWith).WithMessage("the name Must start with the big letter");
            RuleFor(p => p.FirstName).MinimumLength(3);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).Must(IsStartWith).WithMessage("the name Must start with the big letter");
            RuleFor(p => p.LastName).MinimumLength(3);
            RuleFor(p => p.Age).NotEmpty();
            RuleFor(p => p.Age).GreaterThan(0);
            RuleFor(p => p.ChosenMovie).NotEmpty();
            RuleFor(p => p.ChosenMovie).MinimumLength(2);
        }
        private bool IsStartWith(string name)
        {
            if (name[0].ToString()==name[0].ToString().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
