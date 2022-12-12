
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Binding2
{
    internal class YearOfIssueRule : ValidationRule
    {
        private short CurrentYear { get; set; }
        public YearOfIssueRule()
        {
            CurrentYear = (short)DateTime.Now.Year;
        }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            short year;
            if (!short.TryParse(value.ToString(),out year))
            {
                return new ValidationResult(false, "Cannot parse value");
            }
            if (CurrentYear < year)
            {
                return new ValidationResult(false, "Incorrect year");
            }
            return new ValidationResult(true,null);
        }
    }
}
