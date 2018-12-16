using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegaCastingWPF.Rule
{
    public class NumberRule : ValidationRule
    {

        public NumberRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;

            try
            {
                if (int.TryParse((String) value, out result))
                    return ValidationResult.ValidResult;
                else
                    return new ValidationResult(false, "La valeur doit être un nombre.");

            }
            catch (Exception e)
            {
                return new ValidationResult(false, "La valeur doit être un nombre.");
            }
        }
    }
}
