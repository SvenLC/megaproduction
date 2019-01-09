using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Interface
{
    public interface ICrud<T>
    {

        bool Create();
        bool Update();
        bool Delete();
        List<T> list();
        T get(int id);

    }
}
