using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Extends
{
    public class ConnectionModel
    {
        public ConnectionModel(string login, string mdp)
        {
            UTI_LOGIN = login;
            UTI_MDP = mdp;
        }

        [JsonProperty(PropertyName = "UTI_LOGIN")]
        public string UTI_LOGIN { get; set; }

        [JsonProperty(PropertyName = "UTI_MDP")]
        public string UTI_MDP { get; set; }
    }
}
