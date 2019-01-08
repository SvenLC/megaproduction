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
    public partial class T_R_LOCALISATION_LOC : BaseExtend<T_R_LOCALISATION_LOC>
    {

        [JsonProperty(PropertyName = "LOC_ID")]
        public int LOC_ID { get; set; }
        [JsonProperty(PropertyName = "LOC_LIBELLE")]
        public string LOC_LIBELLE { get; set; }

        public override bool Create()
        {

            LocalisationEdit windowEdit = new LocalisationEdit(this);
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Path, byteContent).Result;

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
            LocalisationEdit windowEdit = new LocalisationEdit(this);
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Path + "/" + this.LOC_ID, byteContent).Result;

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
                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Path + "/" + this.LOC_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une offre est associée à cette localisation.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.LOC_ID.ToString();
        }

        public override List<T_R_LOCALISATION_LOC> getSource()
        {
            List<T_R_LOCALISATION_LOC> liste = new List<T_R_LOCALISATION_LOC>();

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["Localisation"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_R_LOCALISATION_LOC> searchResults = new List<T_R_LOCALISATION_LOC>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_R_LOCALISATION_LOC searchResult = result.ToObject<T_R_LOCALISATION_LOC>();
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
                    if (this.LOC_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.LOC_LIBELLE
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
                Binding = new Binding("LOC_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("LOC_LIBELLE")
            });


            return liste;
        }

        public override List<T_R_LOCALISATION_LOC> list()
        {
            throw new NotImplementedException();
        }

        public override T_R_LOCALISATION_LOC get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
