using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Windows;
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
using System.Windows.Controls;
using System.Windows.Data;

namespace MegaCastingWPF.Model.Extends
{
    public class T_R_STATUT_JURIDIQUE_JUR : BaseExtend<T_R_STATUT_JURIDIQUE_JUR>
    {
        [JsonProperty(PropertyName = "JUR_ID")]
        public int JUR_ID { get; set; }
        [JsonProperty(PropertyName = "JUR_LIBELLE")]
        public string JUR_LIBELLE { get; set; }

        public override bool Create()
        {

            StatutEdit windowEdit = new StatutEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
            {
                try
                {
                    using (var client = new HttpClient())
                    {

                        string json = JsonConvert.SerializeObject(this, Formatting.Indented);

                        var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                        var byteContent = new ByteArrayContent(buffer);

                        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.Path, byteContent).Result;

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
            else
            {
                return false;
            }

        }

        public override bool Update()
        {
            StatutEdit windowEdit = new StatutEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
            {
                try
                {
                    using (var client = new HttpClient())
                    {

                        string json = JsonConvert.SerializeObject(this, Formatting.Indented);

                        var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                        var byteContent = new ByteArrayContent(buffer);

                        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.Path + "/" + this.JUR_ID, byteContent).Result;

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
                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.Path + "/" + this.JUR_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une offre est associée à ce statut.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.JUR_ID.ToString();
        }

        public override List<T_R_STATUT_JURIDIQUE_JUR> getSource()
        {
            List<T_R_STATUT_JURIDIQUE_JUR> liste = new List<T_R_STATUT_JURIDIQUE_JUR>();

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["StatutJuridique"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_R_STATUT_JURIDIQUE_JUR> searchResults = new List<T_R_STATUT_JURIDIQUE_JUR>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_R_STATUT_JURIDIQUE_JUR searchResult = result.ToObject<T_R_STATUT_JURIDIQUE_JUR>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }
            }

            return liste;
        }

        public override bool IsRelated(string LOCtain = "")
        {
            Boolean related = false;

            if (LOCtain != "")
            {
                foreach (string item in LOCtain.Split(' ').ToList())
                {
                    if (this.JUR_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
                        related = true;
                }
            }
            else
            {
                related = true;
            }


            return related;
        }

        public override List<TextBlock> PreviewGroupBox()
        {
            List<TextBlock> liste = new List<TextBlock>();

            TextBlock TBC;

            TBC = new TextBlock()
            {
                Text = this.JUR_LIBELLE
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            return liste;
        }

        public override List<DataGridColumn> previewList()
        {
            List<DataGridColumn> liste = new List<DataGridColumn>();

            liste.Add(new DataGridTextColumn()
            {
                Header = "Id",
                Width = new DataGridLength(50),
                FontSize = 12,
                Binding = new Binding("JUR_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("JUR_LIBELLE")
            });


            return liste;
        }

        public override string ToString()
        {
            return this.JUR_LIBELLE;
        }

        public override List<T_R_STATUT_JURIDIQUE_JUR> list()
        {
            throw new NotImplementedException();
        }

        public override T_R_STATUT_JURIDIQUE_JUR get(int id)
        {
            T_R_STATUT_JURIDIQUE_JUR searchResult = new T_R_STATUT_JURIDIQUE_JUR();

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["StatutJuridique"].ToObject<T_R_STATUT_JURIDIQUE_JUR>();
                }
            }

            return searchResult;
        }
    }
}
