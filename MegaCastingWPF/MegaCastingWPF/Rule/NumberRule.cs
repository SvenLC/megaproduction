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
        private bool _isObligated;

        public NumberRule()
        {
            IsObligated = true;
        }

        public bool IsObligated
        {
            get { return _isObligated; }
            set { _isObligated = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int result;

            try
            {
                if ((int.TryParse((String) value, out result)))
                    return ValidationResult.ValidResult;
                else
                {
                    if (IsObligated)
                    {
                        return new ValidationResult(false, "La valeur doit être un nombre.");
                    }
                    else
                    {
                        return ValidationResult.ValidResult;
                    }
                }

            }
            catch (Exception e)
            {
                return new ValidationResult(false, "La valeur doit être un nombre.");
            }
        }
    }
}
