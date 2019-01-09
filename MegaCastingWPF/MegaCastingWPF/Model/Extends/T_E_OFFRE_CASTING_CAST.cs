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
    public class T_E_OFFRE_CASTING_CAST : BaseExtend<T_E_OFFRE_CASTING_CAST>
    {

        [JsonProperty(PropertyName = "CAST_ID")]
        public int CAST_ID { get; set; }
        [JsonProperty(PropertyName = "CAST_INTITULE")]
        public string CAST_INTITULE { get; set; }
        [JsonProperty(PropertyName = "CAST_REFERENCE")]
        public string CAST_REFERENCE { get; set; }
        [JsonProperty(PropertyName = "CAST_DATE_DEBUT_PUBLICATION")]
        public System.DateTime CAST_DATE_DEBUT_PUBLICATION { get; set; }
        [JsonProperty(PropertyName = "CAST_DUREE_DIFFUSION")]
        public System.Int32 CAST_DUREE_DIFFUSION { get; set; }
        [JsonProperty(PropertyName = "CAST_DATE_DEBUT_CONTRAT")]
        public System.DateTime CAST_DATE_DEBUT_CONTRAT { get; set; }
        [JsonProperty(PropertyName = "CAST_NBR_POSTE")]
        public int CAST_NBR_POSTE { get; set; }
        [JsonProperty(PropertyName = "CAST_DESCRIPTION_POSTE")]
        public string CAST_DESCRIPTION_POSTE { get; set; }
        [JsonProperty(PropertyName = "CAST_DESCRIPTION_PROFIL")]
        public string CAST_DESCRIPTION_PROFIL { get; set; }
        [JsonProperty(PropertyName = "PRO_ID")]
        public int PRO_ID { get; set; }
        [JsonProperty(PropertyName = "MET_ID")]
        public int MET_ID { get; set; }
        [JsonProperty(PropertyName = "CTC_ID")]
        public int CTC_ID { get; set; }
        [JsonProperty(PropertyName = "LOC_ID")]
        public int LOC_ID { get; set; }
        [JsonProperty(PropertyName = "CON_ID")]
        public int CON_ID { get; set; }

        public override bool Create()
        {

            OffreEdit windowEdit = new OffreEdit(this);
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

                        HttpResponseMessage response = client.PostAsync(Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Path, byteContent).Result;

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
            OffreEdit windowEdit = new OffreEdit(this);
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

                        HttpResponseMessage response = client.PutAsync(Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Path + "/" + this.CAST_ID, byteContent).Result;

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


                response = client.DeleteAsync(Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Path + "/" + this.CAST_ID).Result;
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                return true;
            }

            MessageBox.Show("Une erreur est survenue lors de la supression.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        public override string GetHeader()
        {
            return this.CAST_ID.ToString();
        }

        public override List<T_E_OFFRE_CASTING_CAST> getSource()
        {
            List<T_E_OFFRE_CASTING_CAST> liste = new List<T_E_OFFRE_CASTING_CAST>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);


                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject googleSearch = JObject.Parse(json);
                    // get JSON result objects into a list
                    IList<JToken> results = googleSearch["offres"].Children().ToList();
                    // serialize JSON results into .NET objects
                    IList<T_E_OFFRE_CASTING_CAST> searchResults = new List<T_E_OFFRE_CASTING_CAST>();
                    foreach (JToken result in results)
                    {
                        // JToken.ToObject is a helper method that uses JsonSerializer internally
                        T_E_OFFRE_CASTING_CAST searchResult = result.ToObject<T_E_OFFRE_CASTING_CAST>();
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
                    if (this.CAST_INTITULE.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.CAST_INTITULE,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_REFERENCE,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_DATE_DEBUT_PUBLICATION.ToString(),
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_DUREE_DIFFUSION.ToString(),
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_DATE_DEBUT_CONTRAT.ToString(),
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_NBR_POSTE.ToString(),
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_DESCRIPTION_POSTE,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.CAST_DESCRIPTION_PROFIL,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            //TBC = new TextBlock()
            //{
            //    Text = this.T_H_CLIENT_CLI.T_E_PROSPECT_PRO.PRO_NAME,
            //};

            //TBC.SetValue(Grid.ColumnProperty, 0);

            //liste.Add(TBC);

            //TBC = new TextBlock()
            //{
            //    Text = this.T_R_METIER_MET.MET_LIBELLE,
            //};

            //TBC.SetValue(Grid.ColumnProperty, 0);

            //liste.Add(TBC);


            //if (this.T_H_CLIENT_CLI != null)
            //{

            //}

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
                Binding = new Binding("CAST_ID")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Intitulé",
                Width = new DataGridLength(150),
                FontSize = 12,
                Binding = new Binding("CAST_INTITULE")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Référence",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CAST_REFERENCE")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Date publication",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CAST_DATE_DEBUT_PUBLICATION")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Durée",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CAST_DUREE_DIFFUSION")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Début contrat",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CAST_DATE_DEBUT_CONTRAT")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Nombre poste",
                Width = new DataGridLength(50),
                FontSize = 12,
                Binding = new Binding("CAST_NBR_POSTE")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Description poste",
                Width = new DataGridLength(150),
                FontSize = 12,
                Binding = new Binding("CAST_DESCRIPTION_POSTE")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Description profil",
                Width = new DataGridLength(150),
                FontSize = 12,
                Binding = new Binding("CAST_DESCRIPTION_PROFIL")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Nom du client",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_H_CLIENT_CLI.T_E_PROSPECT_PRO.PRO_NAME")
            });
            liste.Add(new DataGridTextColumn()
            {
                Header = "Libellé du métier",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_R_METIER_MET.MET_LIBELLE")
            });

            return liste;
        }

        public override List<T_E_OFFRE_CASTING_CAST> list() => getSource();

        public override T_E_OFFRE_CASTING_CAST get(int id)
        {
            T_E_OFFRE_CASTING_CAST searchResult = new T_E_OFFRE_CASTING_CAST();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Database.MegaCastingAPIEntities.token);


                var response = client.GetAsync(Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Path + "/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string json = responseContent.ReadAsStringAsync().Result;
                    JObject rss = JObject.Parse(json);

                    searchResult = rss["offre"].ToObject<T_E_OFFRE_CASTING_CAST>();
                }
            }

            return searchResult;
        }
    }
}
