using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastingWPF.Rule
{
    public class TextRule : ValidationRule
    {
        private int _max;
        private int _min;
        private bool _isObligated;

        public TextRule()
        {
            IsObligated = true;
        }

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public bool IsObligated
        {
            get { return _isObligated; }
            set { _isObligated = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string stringValue = value as String;

            if (((stringValue.Length < Min) || (stringValue.Length > Max)) && IsObligated)
            {
                return new ValidationResult(false,
                  "La longueur doit être comprise entre " + Min + " - " + Max + ".");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }

    }


}
