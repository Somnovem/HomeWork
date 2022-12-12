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
    internal class DigitsOnly : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                int.Parse(value.ToString());
                return new ValidationResult(true, null);
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Not a number");
            }
        }
    }
    internal class DayInMonth : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int day;
            if (!int.TryParse(value.ToString(), out day))
            {
                return new ValidationResult(false, "Cannot parse value");
            }
            return new ValidationResult(true, null);
        }
    }
    internal class DayInYear : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            throw new NotImplementedException();
        }
    }
}
