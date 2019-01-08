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
    public class T_H_CLIENT_CLI : ICrud<T_H_CLIENT_CLI>
    {
        [JsonProperty(PropertyName = "PRO_ID")]
        public int PRO_ID { get; set; }
        [JsonProperty(PropertyName = "CLI_SIRET")]
        public Nullable<int> CLI_SIRET { get; set; }
        [JsonProperty(PropertyName = "CLI_RNA")]
        public Nullable<int> CLI_RNA { get; set; }
        [JsonProperty(PropertyName = "JUR_ID")]
        public int JUR_ID { get; set; }
        [JsonProperty(PropertyName = "ADR_ID")]
        public int ADR_ID { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_E_PROSPECT_PRO get()
        {
            throw new NotImplementedException();
        }

        public List<T_E_PROSPECT_PRO> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        T_H_CLIENT_CLI ICrud<T_H_CLIENT_CLI>.get(int id)
        {
            throw new NotImplementedException();
        }

        List<T_H_CLIENT_CLI> ICrud<T_H_CLIENT_CLI>.list()
        {
            throw new NotImplementedException();
        }
    }
}
