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
    public class T_R_METIER_MET : BaseExtend<T_R_METIER_MET>
    {

        [JsonProperty(PropertyName = "MET_ID")]
        public int MET_ID { get; set; }
        [JsonProperty(PropertyName = "MET_LIBELLE")]
        public string MET_LIBELLE { get; set; }
        [JsonProperty(PropertyName = "DOM_ID")]
        public int DOM_ID { get; set; }

        public string DOM_LIBELLE { get; set; }


        public override bool Create()
        {

            MetierEdit windowEdit = new MetierEdit(this);
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_R_METIER_MET.Path, byteContent).Result;

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
            MetierEdit windowEdit = new MetierEdit(this);
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_R_METIER_MET.Path + "/" + this.MET_ID, byteContent).Result;

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
                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_R_METIER_MET.Path + "/" + this.MET_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Un métier est associée à ce domaine de métier.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.MET_ID.ToString();
        }

        public override List<T_R_METIER_MET> getSource()
        {
            List<T_R_METIER_MET> liste = new List<T_R_METIER_MET>();

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_METIER_MET.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["metier"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_R_METIER_MET> searchResults = new List<T_R_METIER_MET>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_R_METIER_MET searchResult = result.ToObject<T_R_METIER_MET>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }
            }

            foreach (T_R_METIER_MET item in liste)
            {
                item.DOM_LIBELLE = Database.MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.get(item.DOM_ID).DOM_LIBELLE;
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
                    if (this.MET_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.MET_LIBELLE
            };

            TBC = new TextBlock()
            {
                Text = this.DOM_LIBELLE
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
                Binding = new Binding("MET_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("MET_LIBELLE")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Domaine",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("DOM_LIBELLE")
            });


            return liste;
        }

        public override List<T_R_METIER_MET> list()
        {
            throw new NotImplementedException();
        }

        public override T_R_METIER_MET get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
