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
    public class T_S_DATABASE_ADMIN_DBA : ICrud<T_S_DATABASE_ADMIN_DBA>
    {
        [JsonProperty(PropertyName = "DBA_ID")]
        public int DBA_ID { get; set; }
        [JsonProperty(PropertyName = "DBA_DATEHEURE")]
        public System.DateTime DBA_DATEHEURE { get; set; }
        [JsonProperty(PropertyName = "DBA_NOM")]
        public string DBA_NOM { get; set; }
        [JsonProperty(PropertyName = "DBA_NATURE")]
        public string DBA_NATURE { get; set; }
        [JsonProperty(PropertyName = "DBA_COMMANDE")]
        public string DBA_COMMANDE { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_S_DATABASE_ADMIN_DBA get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_S_DATABASE_ADMIN_DBA> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
