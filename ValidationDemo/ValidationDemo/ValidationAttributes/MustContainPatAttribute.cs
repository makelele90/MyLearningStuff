
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ValidationDemo.ValidationAttributes
{
  public class MustContainPatAttribute : ValidationAttribute, IClientValidatable
  {

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

      if (value != null)
      {
        if (!string.IsNullOrWhiteSpace(value.ToString()))
        {
          var valueString = value.ToString();

           if (valueString.Contains("pat"))
           
             return ValidationResult.Success;
        }
      }

      return new ValidationResult("username must contain patou");
    }

    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
    {

      var rule = new ModelClientValidationRule()
        {
          ErrorMessage = FormatErrorMessage(metadata.DisplayName),
          ValidationType = "mustcontainpat"
          
        };

      rule.ValidationParameters.Add("additional1", "dam i'm good");
      rule.ValidationParameters.Add("additional2", "dam i'm genius");
      yield return rule;
    }
  }
}