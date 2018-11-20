using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model
{
    public class Test
    {
        private string nom;

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public Test(string _nom)
        {
            nom = _nom;
        }
    }
}
