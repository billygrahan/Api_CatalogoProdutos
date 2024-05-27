﻿using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Validations
{
    public class PrimeiraLetraMaiusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value == null || string.IsNullOrEmpty(value.ToString())){
                return ValidationResult.Success;
            }

            var primeiraletra = value.ToString()[0].ToString();
            if(primeiraletra != primeiraletra.ToUpper())
            {
                return new ValidationResult("A primeira letra do nome não é maiuscula!");
            }

            return ValidationResult.Success;
        }
    }
}
