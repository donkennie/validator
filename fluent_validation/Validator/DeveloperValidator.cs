using fluent_validation.Models;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Validator
{
    public class DeveloperValidator : AbstractValidator<Developer>
    {
        public DeveloperValidator()
        {

            RuleFor(p => p.FirstName)
                 .Cascade(CascadeMode.StopOnFirstFailure)
                 .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                 .Length(2, 25)
                 .Must(IsValidName).WithMessage("{PropertyName} should be all letters.")
                  .Matches(@"^[A-Z]+[a-zA-Z]*$"); 

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters.");

            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex);

        }
            private bool IsValidName(string name)
            {
                return name.All(Char.IsLetter);
            }

            /*RuleFor(x => x.Id).NotNull();
    RuleFor(x => x.Name).Length(0, 10);
    RuleFor(x => x.Email).EmailAddress();
    RuleFor(x => x.Age).InclusiveBetween(18, 60);*/

            /* RuleFor(x => x.Products)
                .NotNull()
                .WithMessage(ProductErrors.ProductErrorMessage)
                .Must(x => x.Any())
                .WithMessage(ProductErrors.ProductErrorMessage);

RuleFor(x => x.Products.Select(p => p.Id))
.Must(x => !x.Any(s => s <= 0))
            	.WithMessage(ProductErrors.IdErrorMessage);

            RuleFor(x => x.Products.Select(p => p.Seller))
               .Must(n => !n.Any(s => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)))
               .WithMessage(ProductErrors.SellerErrorMessage);
            
            RuleFor(x => x.Products.Select(p => p.Name))
                .Must(x => !x.Any(s => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)))
                .WithMessage(ProductErrors.NameErrorMessage);

            RuleFor(x => x.Products.Select(p => p.CatRefId))
                .Must(x => !x.Any(s => string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)))
                .WithMessage(ProductErrors.CatRefIdErrorMessage);

            RuleFor(x => x.Products.Select(p => p.Quantity))
               .Must(x => !x.Any(s => s <= 0))
               .WithMessage(ProductErrors.QuantityErrorMessage);
            RuleFor(customer => customer.Password).Equal(customer => customer.PasswordConfirmation);*/
        
    }
}
