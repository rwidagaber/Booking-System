using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Validations
{
  
    public class FutureDateAttribute : ValidationAttribute,IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");

            context.Attributes.Add("data-val-futuredate",
                ErrorMessage ?? "Date must be in the future");
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            
            if (DateTime.TryParse(value.ToString(), out DateTime dateValue))
            {
                
                return dateValue.Date >= DateTime.Today;
            }

            return false; 
        }
    }
}