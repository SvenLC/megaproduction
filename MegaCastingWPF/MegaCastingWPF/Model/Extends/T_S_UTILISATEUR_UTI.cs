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
    public class T_S_UTILISATEUR_UTI : BaseExtend<T_S_UTILISATEUR_UTI>
    {


        [JsonProperty(PropertyName = "UTI_ID")]
        public int UTI_ID { get; set; }
        [JsonProperty(PropertyName = "UTI_NOM")]
        public string UTI_NOM { get; set; }
        [JsonProperty(PropertyName = "UTI_PRENOM")]
        public string UTI_PRENOM { get; set; }
        [JsonProperty(PropertyName = "UTI_LOGIN")]
        public string UTI_LOGIN { get; set; }
        [JsonProperty(PropertyName = "UTI_MDP")]
        public string UTI_MDP { get; set; }
        [JsonProperty(PropertyName = "UTI_ADMINISTRATEUR")]
        public bool UTI_ADMINISTRATEUR { get; set; }

        public override bool Create()
        {

            UtilisateurEdit windowEdit = new UtilisateurEdit(this);
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Path, byteContent).Result;

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
            UtilisateurEdit windowEdit = new UtilisateurEdit(this);
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Path + "/" + this.UTI_ID, byteContent).Result;

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
                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Path + "/" + this.UTI_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Cet utilisateur ne peut pas être supprimer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.UTI_ID + " - " + this.UTI_LOGIN;
        }

        public override List<T_S_UTILISATEUR_UTI> getSource()
        {
            List<T_S_UTILISATEUR_UTI> liste = new List<T_S_UTILISATEUR_UTI>();

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["utilisateurs"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_S_UTILISATEUR_UTI> searchResults = new List<T_S_UTILISATEUR_UTI>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_S_UTILISATEUR_UTI searchResult = result.ToObject<T_S_UTILISATEUR_UTI>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }
            }

            return liste;

            throw new NotImplementedException();
        }

        public override bool IsRelated(string contain = "")
        {
            Boolean related = false;

            if (contain != "")
            {
                foreach (string item in contain.Split(' ').ToList())
                {
                    if (this.UTI_LOGIN.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.UTI_NOM
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.UTI_PRENOM
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.UTI_ADMINISTRATEUR.ToString()
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
                Binding = new Binding("UTI_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("UTI_LOGIN")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Nom",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("UTI_NOM")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Prénom",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("UTI_PRENOM")
            });

            liste.Add(new DataGridCheckBoxColumn()
            {
                Header = "Administrateur",
                Width = new DataGridLength(100),
                Binding = new Binding("UTI_ADMINISTRATEUR")
            });

            return liste;
        }

        public override List<T_S_UTILISATEUR_UTI> list()
        {
            throw new NotImplementedException();
        }

        public override T_S_UTILISATEUR_UTI get(int id)
        {
            T_S_UTILISATEUR_UTI searchResult = null;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss.ToObject<T_S_UTILISATEUR_UTI>();
                }
            }

            return searchResult;
        }

        public static string connect(string userName, string passWord)
        {
            string id = "";

            using (var client = new HttpClient())
            {

                #region ReadList
                    //var response = client.GetAsync("https://megacastingprivateapi.azurewebsites.net/auth/login").Result;
                    //if (response.IsSuccessStatusCode)
                    //{
                    //    var responseContent = response.Content;
                    //    string json = responseContent.ReadAsStringAsync().Result;
                    //    JObject googleSearch = JObject.Parse(json);
                    //    // get JSON result objects into a list
                    //    IList<JToken> results = googleSearch["utilisateurs"].Children().ToList();
                    //    // serialize JSON results into .NET objects
                    //    IList<T_S_UTILISATEUR_UTI> searchResults = new List<T_S_UTILISATEUR_UTI>();
                    //    foreach (JToken result in results)
                    //    {
                    //        // JToken.ToObject is a helper method that uses JsonSerializer internally
                    //        T_S_UTILISATEUR_UTI searchResult = result.ToObject<T_S_UTILISATEUR_UTI>();
                    //        searchResults.Add(searchResult);
                    //    }
                    //}
                #endregion

                ConnectionModel model = new ConnectionModel(userName, passWord);

                string json = JsonConvert.SerializeObject(model, Formatting.Indented);

                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);

                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = client.PostAsync("https://megacastingprivateapi.azurewebsites.net/auth/login", byteContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseJson = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(responseJson);
                    id = (string)rss["UTI_ID"];
                }

            }

            return id;
        }
    }
}
