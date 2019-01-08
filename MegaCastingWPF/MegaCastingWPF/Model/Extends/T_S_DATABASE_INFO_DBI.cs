using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Extends
{
    public class T_S_DATABASE_INFO_DBI : ICrud<T_S_DATABASE_INFO_DBI>
    {
        [JsonProperty(PropertyName = "DBI_LIBELLE")]
        public string DBI_LIBELLE { get; set; }
        [JsonProperty(PropertyName = "DBI_TYPE")]
        public string DBI_TYPE { get; set; }
        [JsonProperty(PropertyName = "DBI_VALEUR")]
        public string DBI_VALEUR { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_S_DATABASE_INFO_DBI get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_S_DATABASE_INFO_DBI> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
