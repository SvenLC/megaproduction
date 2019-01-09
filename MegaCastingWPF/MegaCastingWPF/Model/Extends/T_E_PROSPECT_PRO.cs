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
    public class T_E_PROSPECT_PRO : BaseExtend<T_E_PROSPECT_PRO>
    {
        [JsonProperty(PropertyName = "PRO_ID")]
        public int PRO_ID { get; set; }
        [JsonProperty(PropertyName = "PRO_NAME")]
        public string PRO_NAME { get; set; }
        [JsonProperty(PropertyName = "CLI_RNA")]
        public int? CLI_RNA { get; set; }
        [JsonProperty(PropertyName = "CLI_SIRET")]
        public int? CLI_SIRET { get; set; }
        [JsonProperty(PropertyName = "PAR_LOGIN")]
        public string PAR_LOGIN { get; set; }

        public T_H_PARTENAIRES_PAR partenaire { get; set; }
        public T_H_CLIENT_CLI clientAdd { get; set; }
        public T_E_ADRESSE_ADR addresse { get; set; }

        public List<T_E_CONTACT_CTC> listContactAdd = new List<T_E_CONTACT_CTC>();


        public override bool IsRelated(string contain = "")
        {
            Boolean related = false;

            if (contain != "")
            {
                foreach (string item in contain.Split(' ').ToList())
                {
                    if (this.PRO_NAME.ToLower().Contains(item.ToLower()) && item != "")
                        related = true;
                }
            }
            else
            {
                related = true;
            }
             

            return related;
        }

        public override string GetHeader()
        {
            return this.PRO_ID.ToString() + " - " + this.PRO_NAME;
        }

        public override List<TextBlock> PreviewGroupBox()
        {

            List<TextBlock> liste = new List<TextBlock>();

            TextBlock TBC;

            TBC = new TextBlock()
            {
                Text = "Partenaire",
                FontWeight = FontWeight.FromOpenTypeWeight(750)
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.PAR_LOGIN
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = "Client",
                FontWeight = FontWeight.FromOpenTypeWeight(750)
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CLI_RNA.ToString()
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CLI_SIRET.ToString()
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
                Binding = new Binding("PRO_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Nom",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("PRO_NAME")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "RNA",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CLI_RNA")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "SIRET",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CLI_SIRET")
            });


            liste.Add(new DataGridTextColumn()
            {
                Header = "Utilisateur",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("PAR_LOGIN")
            });

            return liste;
        }

        public override bool Create()
        {
            ProspectEdit windowEdit = new ProspectEdit(this);
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Path, byteContent).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = response.Content;
                            string json2 = responseContent.ReadAsStringAsync().Result;
                            JObject rss = JObject.Parse(json2);

                            T_E_PROSPECT_PRO searchResult = rss["prospect"].ToObject<T_E_PROSPECT_PRO>();

                            this.PRO_ID = searchResult.PRO_ID;
                                
                            if (this.clientAdd != null && this.addresse != null)
                            {
                                this.addresse.Create();
                                clientAdd.ADR_ID = addresse.ADR_ID;
                                clientAdd.PRO_ID = this.PRO_ID;
                                clientAdd.Create();
                            }

                            if (this.partenaire != null)
                            {
                                partenaire.PRO_ID = this.PRO_ID;
                                partenaire.Create();
                            }

                            if (listContactAdd.Count > 0)
                            {
                                foreach (T_E_CONTACT_CTC item in listContactAdd)
                                {
                                    if (item.CTC_ID == 0)
                                    {
                                        item.PRO_ID = this.PRO_ID;
                                        item.saveCreate();
                                    }
                                    else
                                    {
                                        item.saveUpdate();
                                    }
                                }
                            }

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
            ProspectEdit windowEdit = new ProspectEdit(this);
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Path + "/" + this.PRO_ID, byteContent).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = response.Content;
                            string json2 = responseContent.ReadAsStringAsync().Result;
                            JObject rss = JObject.Parse(json2);

                            T_E_PROSPECT_PRO searchResult = rss["prospect"].ToObject<T_E_PROSPECT_PRO>();

                            this.PRO_ID = searchResult.PRO_ID;


                            if (this.clientAdd != null && this.addresse != null)
                            {
                                if (addresse.ADR_ID != 0)
                                {
                                    this.addresse.Update();
                                    clientAdd.ADR_ID = addresse.ADR_ID;
                                }
                                else
                                {
                                    this.addresse.Create();
                                    clientAdd.ADR_ID = addresse.ADR_ID;
                                }

                                if (clientAdd.PRO_ID != 0)
                                {
                                    clientAdd.PRO_ID = this.PRO_ID;
                                    clientAdd.Update();
                                }
                                else
                                {
                                    clientAdd.PRO_ID = this.PRO_ID;
                                    clientAdd.Create();
                                }
                                
                                
                            }

                            if (this.partenaire != null)
                            {
                                if (partenaire.PRO_ID != 0)
                                {
                                    partenaire.PRO_ID = this.PRO_ID;
                                    partenaire.Update();
                                }
                                else
                                {
                                    partenaire.PRO_ID = this.PRO_ID;
                                    partenaire.Create();
                                }
                            }

                            if (listContactAdd.Count > 0)
                            {
                                foreach (T_E_CONTACT_CTC item in listContactAdd)
                                {
                                    if (item.CTC_ID == 0)
                                    {
                                        item.PRO_ID = this.PRO_ID;
                                        item.saveCreate();
                                    }
                                    else
                                    {
                                        item.saveUpdate();
                                    }
                                }
                            }

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


                T_H_CLIENT_CLI ClientRemove = Database.MegeCastingDatabase.Current.T_H_CLIENT_CLI.get(this.PRO_ID);
                if (ClientRemove != null)
                {
                    T_E_ADRESSE_ADR addresse = Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.get(ClientRemove.ADR_ID);
                    if (addresse != null)
                    {
                        ClientRemove.Delete();
                        addresse.Delete();
                    }
                }

                List<T_E_CONTACT_CTC> listContact = Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.list();
                try
                {
                    if (listContact.Count >= 1)
                    {
                        foreach (T_E_CONTACT_CTC item in listContact)
                        {
                            item.Delete();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Une offre est associée à ce prospect.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                

                T_H_PARTENAIRES_PAR ParRemove = Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.get(this.PRO_ID);
                if (ParRemove != null)
                {
                    ParRemove.Delete();
                }

                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Path + "/" + this.PRO_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une entité est associée à ce prospect.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override List<T_E_PROSPECT_PRO> getSource()
        {
            List<T_E_PROSPECT_PRO> liste = new List<T_E_PROSPECT_PRO>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync("https://megacastingprivateapi.azurewebsites.net/prospects/formated").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["Prospects"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_E_PROSPECT_PRO> searchResults = new List<T_E_PROSPECT_PRO>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_E_PROSPECT_PRO searchResult = result.ToObject<T_E_PROSPECT_PRO>();
                        searchResults.Add(searchResult);
                    }
                    liste = searchResults.ToList();
                }

                //foreach (T_E_PROSPECT_PRO item in liste)
                //{
                //    if (item.PAR_LOGIN == null)
                //    {
                //        T_H_PARTENAIRES_PAR partenaire = Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.get(item.PRO_ID);

                //        item.PAR_LOGIN = partenaire.PAR_LOGIN;
                //    }

                //    if (item.CLI_SIRET == null && item.CLI_RNA == null)
                //    {
                //        T_H_CLIENT_CLI client2 = Database.MegeCastingDatabase.Current.T_H_CLIENT_CLI.get(item.PRO_ID);

                //        item.CLI_RNA = client2.CLI_RNA;
                //        item.CLI_SIRET = client2.CLI_SIRET;
                //    }
                //}

            }

            return liste;
        }

        public override List<T_E_PROSPECT_PRO> list() => getSource();

        public override T_E_PROSPECT_PRO get(int id)
        {
            T_E_PROSPECT_PRO searchResult = new T_E_PROSPECT_PRO();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);

                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["prospects"].ToObject<T_E_PROSPECT_PRO>();
                }
            }

            return searchResult;
        }
    }
}
