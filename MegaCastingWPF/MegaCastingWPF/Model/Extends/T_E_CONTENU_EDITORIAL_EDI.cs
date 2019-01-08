using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaCastingWPF.Model.Extends
{
    public class T_E_CONTENU_EDITORIAL_EDI : ICrud<T_E_CONTENU_EDITORIAL_EDI>
    {
        [JsonProperty(PropertyName = "EDI_ID")]
        public int EDI_ID { get; set; }
        [JsonProperty(PropertyName = "EDI_DESCRIPTION")]
        public string EDI_DESCRIPTION { get; set; }
        [JsonProperty(PropertyName = "EDI_CONTENU")]
        public string EDI_CONTENU { get; set; }
        [JsonProperty(PropertyName = "CET_ID")]
        public int CET_ID { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_E_CONTENU_EDITORIAL_EDI get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_E_CONTENU_EDITORIAL_EDI> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
