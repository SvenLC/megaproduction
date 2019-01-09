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
    public class T_X_CODE_POSTAL_CPT : ICrud<T_X_CODE_POSTAL_CPT>
    {
        [JsonProperty(PropertyName = "CPT_ID")]
        public int CPT_ID { get; set; }
        [JsonProperty(PropertyName = "CPT_CODE_POSTAL")]
        public string CPT_CODE_POSTAL { get; set; }
        [JsonProperty(PropertyName = "CPT_VILLE")]
        public string CPT_VILLE { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_X_CODE_POSTAL_CPT get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_X_CODE_POSTAL_CPT> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
