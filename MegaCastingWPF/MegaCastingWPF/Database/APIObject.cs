using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Database
{
    public class APIObject <T> where T : ICrud, new()
    {
        public string Path = "";

        public APIObject(string path)
        {
            this.Path = path;
        }

        public T get(int id)
        {
            throw new NotImplementedException();
        }

        public bool add(T objet)
        {
            return objet.Create();
        }

        public bool update(int id)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> list()
        {
            throw new NotImplementedException();
        }

    }
}
