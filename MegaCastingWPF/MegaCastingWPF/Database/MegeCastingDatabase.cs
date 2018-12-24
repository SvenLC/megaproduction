using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Database
{
    public class MegeCastingDatabase
    {
        #region Singleton var

        private static Lazy<MegaCastingEntities> Instance = new Lazy<MegaCastingEntities>(() => new MegaCastingEntities());

        public static MegaCastingEntities Current => Instance.Value;

        #endregion

        #region Static Funcs

        public static void ReinitializeDatabase()
        {
            if (Instance.IsValueCreated)
            {
                Instance = new Lazy<MegaCastingEntities>(() => new MegaCastingEntities());
            }
        }

        #endregion
    }
}
