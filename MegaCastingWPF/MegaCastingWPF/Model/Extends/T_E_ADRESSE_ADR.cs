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
    public class T_E_ADRESSE_ADR : ICrud<T_E_ADRESSE_ADR>
    {
        [JsonProperty(PropertyName = "ADR_ID")]
        public int ADR_ID { get; set; }

        [JsonProperty(PropertyName = "ADR_NUM_VOIE")]
        public string ADR_NUM_VOIE { get; set; }

        [JsonProperty(PropertyName = "ADR_LIBELLE_RUE")]
        public string ADR_LIBELLE_RUE { get; set; }

        [JsonProperty(PropertyName = "ADR_VILLE")]
        public string ADR_VILLE { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_E_ADRESSE_ADR get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_E_ADRESSE_ADR> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
