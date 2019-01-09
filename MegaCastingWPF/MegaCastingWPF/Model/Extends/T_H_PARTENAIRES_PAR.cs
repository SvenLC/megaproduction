using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                    string json = JsonConvert.SerializeObject(this, Formatting.Indented);

                    var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                    var byteContent = new ByteArrayContent(buffer);

                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.Path, byteContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }

                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                    string json = JsonConvert.SerializeObject(this, Formatting.Indented);

                    var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                    var byteContent = new ByteArrayContent(buffer);

                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.Path + "/" + this.PRO_ID, byteContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }

                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            HttpResponseMessage response = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.Path + "/" + this.PRO_ID).Result;
            }

            return true;
        }

        public T_H_PARTENAIRES_PAR get(int id)
        {
            T_H_PARTENAIRES_PAR searchResult = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["partenaire"].ToObject<T_H_PARTENAIRES_PAR>();
                }
            }

            return searchResult;
        }

        public List<T_H_PARTENAIRES_PAR> list()
        {
            throw new NotImplementedException();
        }

    }
}
