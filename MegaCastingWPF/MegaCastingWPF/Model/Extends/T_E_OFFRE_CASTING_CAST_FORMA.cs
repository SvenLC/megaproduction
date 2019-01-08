using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MegaCastingWPF.Model.Extends
{
    public class T_E_OFFRE_CASTING_CAST_FORMA : BaseExtend<T_E_OFFRE_CASTING_CAST_FORMA>
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

        [JsonProperty(PropertyName = "PRO_NAME")]
        public int PRO_NAME { get; set; }

        [JsonProperty(PropertyName = "MET_LIBELLE")]
        public int MET_LIBELLE { get; set; }

        [JsonProperty(PropertyName = "CTC_EMAIL")]
        public int CTC_EMAIL { get; set; }

        [JsonProperty(PropertyName = "LOC_LIBELLE")]
        public int LOC_LIBELLE { get; set; }

        [JsonProperty(PropertyName = "CON_LIBELLE")]
        public int CON_LIBELLE { get; set; }

        public override bool Create()
        {
            //bool isSucces = this.Update();

            //if (isSucces)
            //{
            //    Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Add(this);

            //    try
            //    {
            //        MegeCastingDatabase.Current.SaveChanges();
            //        return true;
            //    }
            //    catch (Exception)
            //    {
            //        Database.MegeCastingDatabase.ReinitializeDatabase();
            //        return false;
            //    }
            //}
            //else
            //{
            //    Database.MegeCastingDatabase.ReinitializeDatabase();
            //    return false;
            //}

            throw new NotImplementedException();
        }

        public override bool Update()
        {
            //OffreEdit windowEdit = new OffreEdit(this);
            //windowEdit.ShowDialog();

            //if (windowEdit.DialogResult.HasValue && windowEdit.DialogResult.Value == true)
            //{
            //    try
            //    {
            //        MegeCastingDatabase.Current.SaveChanges();
            //        return true;
            //    }
            //    catch (Exception)
            //    {
            //        Database.MegeCastingDatabase.ReinitializeDatabase();
            //        return false;
            //    }
            //}
            //else
            //{
            //    Database.MegeCastingDatabase.ReinitializeDatabase();
            //    return false;
            //}

            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            //T_E_OFFRE_CASTING_CAST objectSelect = Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Where(x => x.CAST_ID == this.CAST_ID).First();

            //Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Remove(objectSelect);

            //try
            //{
            //    MegeCastingDatabase.Current.SaveChanges();
            //    Database.MegeCastingDatabase.ReinitializeDatabase();
            //    return true;
            //}
            //catch (Exception)
            //{
            //    Database.MegeCastingDatabase.ReinitializeDatabase();
            //    return false;
            //}

            throw new NotImplementedException();
        }

        public override string GetHeader()
        {
            return this.CAST_ID.ToString();
        }

        public override List<T_E_OFFRE_CASTING_CAST_FORMA> getSource()
        {
            List<T_E_OFFRE_CASTING_CAST_FORMA> liste = new List<T_E_OFFRE_CASTING_CAST_FORMA>();

            //using (var client = new HttpClient())
            //{
            //    var response = client.GetAsync("https://megacastingprivateapi.azurewebsites.net/offreCastings/formated").Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var responseContent = response.Content;
            //        string json = responseContent.ReadAsStringAsync().Result;
            //        JObject googleSearch = JObject.Parse(json);
            //        // get JSON result objects into a list
            //        IList<JToken> results = googleSearch["offres"].Children().ToList();
            //        // serialize JSON results into .NET objects
            //        IList<T_E_OFFRE_CASTING_CAST_FORMA> searchResults = new List<T_E_OFFRE_CASTING_CAST_FORMA>();
            //        foreach (JToken result in results)
            //        {
            //            // JToken.ToObject is a helper method that uses JsonSerializer internally
            //            T_E_OFFRE_CASTING_CAST_FORMA searchResult = result.ToObject<T_E_OFFRE_CASTING_CAST_FORMA>();
            //            searchResults.Add(searchResult);
            //        }
            //        liste = searchResults.ToList();
            //    }
            //}

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

        public override List<T_E_OFFRE_CASTING_CAST_FORMA> list()
        {
            throw new NotImplementedException();
        }

        public override T_E_OFFRE_CASTING_CAST_FORMA get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
