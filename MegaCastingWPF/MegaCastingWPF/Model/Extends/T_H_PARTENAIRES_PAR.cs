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
    public class T_H_PARTENAIRES_PAR : ICrud<T_H_PARTENAIRES_PAR>
    {
        [JsonProperty(PropertyName = "PRO_ID")]
        public int PRO_ID { get; set; }
        [JsonProperty(PropertyName = "PAR_LOGIN")]
        public string PAR_LOGIN { get; set; }
        [JsonProperty(PropertyName = "PAR_MDP")]
        public string PAR_MDP { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_H_PARTENAIRES_PAR get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_H_PARTENAIRES_PAR> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
