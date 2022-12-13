using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_MultiConverterAndRules
{
    public class DigitsOnly : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (int.TryParse(value.ToString(),out int number))
            {
                return ValidationResult.ValidResult;
            }
            return new ValidationResult(false, "Not a number");
        }
    }
}
