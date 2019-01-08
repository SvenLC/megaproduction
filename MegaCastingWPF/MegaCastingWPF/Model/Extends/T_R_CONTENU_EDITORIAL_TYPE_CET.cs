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
    public class T_R_CONTENU_EDITORIAL_TYPE_CET : ICrud<T_R_CONTENU_EDITORIAL_TYPE_CET>
    {
        [JsonProperty(PropertyName = "CET_ID")]
        public int CET_ID { get; set; }
        [JsonProperty(PropertyName = "CET_LIBELLE")]
        public string CET_LIBELLE { get; set; }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public T_R_CONTENU_EDITORIAL_TYPE_CET get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T_R_CONTENU_EDITORIAL_TYPE_CET> list()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
