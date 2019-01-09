using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Database
{
    public static class MegeCastingDatabase
    {
        #region Singleton var

        private static MegaCastingAPIEntities Instance = new MegaCastingAPIEntities();

        public static MegaCastingAPIEntities Current => Instance;

        #endregion
        
    }
}
