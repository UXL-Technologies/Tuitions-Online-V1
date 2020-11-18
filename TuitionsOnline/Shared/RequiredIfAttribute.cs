using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TuitionsOnline.Shared
{
    public class RequiredIfAttribute : RequiredAttribute
    {
        private String PropertyName { get; set; }



        public RequiredIfAttribute(String propertyName)
        {
            PropertyName = propertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            Object instance = context.ObjectInstance;
            Type type = instance.GetType();
            Object propertyValue = type.GetProperty(PropertyName)?.GetValue(instance, null);
            if (!(bool)propertyValue)
                return ValidationResult.Success;



            if (value == null)
            {
                ValidationResult result = base.IsValid(value, context);
                return result;
            }

            var incomingValue = value.ToString();
            if (string.IsNullOrEmpty(incomingValue))
            {
                ValidationResult result = base.IsValid(value, context);
                return result;
            }

            return ValidationResult.Success;
        }

    }
}
