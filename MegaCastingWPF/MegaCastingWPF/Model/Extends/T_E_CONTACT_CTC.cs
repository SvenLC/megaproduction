using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using Newtonsoft.Json.Linq;

namespace MegaCastingWPF.Model.Extends
{
    public class T_E_CONTACT_CTC : BaseExtend<T_E_CONTACT_CTC>
    {
        [JsonProperty(PropertyName = "CTC_ID")]
        public int CTC_ID { get; set; }
        [JsonProperty(PropertyName = "CTC_DESCRIPTION")]
        public string CTC_DESCRIPTION { get; set; }
        [JsonProperty(PropertyName = "CTC_NUM_TEL")]
        public string CTC_NUM_TEL { get; set; }
        [JsonProperty(PropertyName = "CTC_NUM_FAX")]
        public string CTC_NUM_FAX { get; set; }
        [JsonProperty(PropertyName = "CTC_EMAIL")]
        public string CTC_EMAIL { get; set; }
        [JsonProperty(PropertyName = "CTC_PRINCIPALE")]
        public bool CTC_PRINCIPALE { get; set; }
        [JsonProperty(PropertyName = "PRO_ID")]
        public int PRO_ID { get; set; }

        public override bool IsRelated(string contain = "")
        {
            Boolean related = false;

            if (contain != "")
            {
                if (this.PRO_ID.ToString() == contain)
                    related = true;
            }


            return related;
        }

        public override string GetHeader()
        {
            throw new NotImplementedException();
        }

        public override List<TextBlock> PreviewGroupBox()
        {
            throw new NotImplementedException();
        }

        public override List<DataGridColumn> previewList()
        {
            List<DataGridColumn> liste = new List<DataGridColumn>();

            liste.Add(new DataGridTextColumn()
            {
                Header = "Id",
                Width = new DataGridLength(50),
                FontSize = 12,
                Binding = new Binding("CTC_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Description",
                Width = new DataGridLength(150),
                FontSize = 12,
                Binding = new Binding("CTC_DESCRIPTION")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Email",
                Width = new DataGridLength(200),
                FontSize = 12,
                Binding = new Binding("CTC_EMAIL")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Fax",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_NUM_FAX")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Téléphone",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_NUM_TEL")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Principale",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_PRINCIPALE")
            });

            return liste;
        }

        public override bool Create()
        {
            ContactEdit windowEdit = new ContactEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override bool Update()
        {
            ContactEdit windowEdit = new ContactEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Delete()
        {
            HttpResponseMessage response = null;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Path + "/" + this.CTC_ID).Result;
            }

            return true;
        }

        public bool saveCreate()
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

                    HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Path, byteContent).Result;

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

        public bool saveUpdate()
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

                    HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Path + "/" + this.CTC_ID, byteContent).Result;

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

        public override List<T_E_CONTACT_CTC> getSource()
        {
            List<T_E_CONTACT_CTC> liste = new List<T_E_CONTACT_CTC>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["contact"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_E_CONTACT_CTC> searchResults = new List<T_E_CONTACT_CTC>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_E_CONTACT_CTC searchResult = result.ToObject<T_E_CONTACT_CTC>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }
            }

            return liste;
        }

        public override List<T_E_CONTACT_CTC> list() => getSource();

        public override T_E_CONTACT_CTC get(int id)
        {
            T_E_CONTACT_CTC searchResult = new T_E_CONTACT_CTC();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["contact"].ToObject<T_E_CONTACT_CTC>();
                }
            }

            return searchResult;
        }
    }
}
