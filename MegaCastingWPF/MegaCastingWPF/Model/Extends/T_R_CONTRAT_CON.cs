﻿using MegaCastingWPF.Model.Extends;
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
    public class T_R_CONTRAT_CON : BaseExtend<T_R_CONTRAT_CON>
    {
        [JsonProperty(PropertyName = "CON_ID")]
        public int CON_ID { get; set; }
        [JsonProperty(PropertyName = "CON_LIBELLE")]
        public string CON_LIBELLE { get; set; }

        public override bool Create()
        {

            ContratEdit windowEdit = new ContratEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.Path, byteContent).Result;

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
            ContratEdit windowEdit = new ContratEdit(this);
            windowEdit.ShowDialog();

            if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.Path + "/" + this.CON_ID, byteContent).Result;

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
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.Path + "/" + this.CON_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une offre est associée à ce contrat.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.CON_ID.ToString();
        }

        public override List<T_R_CONTRAT_CON> getSource()
        {
            List<T_R_CONTRAT_CON> liste = new List<T_R_CONTRAT_CON>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["contrat"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_R_CONTRAT_CON> searchResults = new List<T_R_CONTRAT_CON>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_R_CONTRAT_CON searchResult = result.ToObject<T_R_CONTRAT_CON>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }
            }

            return liste;
        }

        public override bool IsRelated(string contain = "")
        {
            Boolean related = false;

            if (contain != "")
            {
                foreach (string item in contain.Split(' ').ToList())
                {
                    if (this.CON_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.CON_LIBELLE
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
                Binding = new Binding("CON_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CON_LIBELLE")
            });


            return liste;
        }

        public override List<T_R_CONTRAT_CON> list() => getSource();

        public override T_R_CONTRAT_CON get(int id)
        {
            T_R_CONTRAT_CON searchResult = new T_R_CONTRAT_CON();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["contrat"].ToObject<T_R_CONTRAT_CON>();
                }
            }

            return searchResult;
        }
    }
}
