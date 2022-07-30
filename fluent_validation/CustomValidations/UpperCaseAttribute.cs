using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.CustomValidations
{
    public class UpperCaseAttribute: ValidationAttribute, IClientModelValidator
    {
        public UpperCaseAttribute()
        {
            ErrorMessage = "Must be Upper case";
        }

        public IEnumerable<ModelClientValidationRule>

       /* public void AddValidation(ClientModelValidationContext context)
        {
            throw new NotImplementedException();
        }

        public override bool IsValid(object value)
        {
            if (!(value is string s))
                throw new ArgumentException("Not a string");
            return s == s.ToUpper(); 
        }*/
    }
}
