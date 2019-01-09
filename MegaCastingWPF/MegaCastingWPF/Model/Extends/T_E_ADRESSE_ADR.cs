using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using Newtonsoft.Json.Linq;

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
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                    string json = JsonConvert.SerializeObject(this, Formatting.Indented);

                    var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                    var byteContent = new ByteArrayContent(buffer);

                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.Path, byteContent).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string json2 = responseContent.ReadAsStringAsync().Result;
                        JObject rss = JObject.Parse(json2);

                        T_E_ADRESSE_ADR searchResult = rss["adresse"].ToObject<T_E_ADRESSE_ADR>();

                        this.ADR_ID = searchResult.ADR_ID;

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

                    HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.Path + "/" + this.ADR_ID, byteContent).Result;

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


                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.Path + "/" + this.ADR_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une offre est associée à ce contrat.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public bool Delete(int id)
        {
            HttpResponseMessage response = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);


                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.Path + "/" + id).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public T_E_ADRESSE_ADR get(int id)
        {
            T_E_ADRESSE_ADR searchResult = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["adresse"].ToObject<T_E_ADRESSE_ADR>();
                }
            }

            return searchResult;
        }

        public List<T_E_ADRESSE_ADR> list()
        {
            throw new NotImplementedException();
        }

    }
}
