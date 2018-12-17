using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MegaCastingWPF.Database
{
    public partial class T_E_OFFRE_CASTING_CAST : BaseExtend
    {

        //public int CAST_ID { get; set; }
        //public string CAST_INTITULE { get; set; }
        //public string CAST_REFERENCE { get; set; }
        //public System.DateTime CAST_DATE_DEBUT_PUBLICATION { get; set; }
        //public System.TimeSpan CAST_DUREE_DIFFUSION { get; set; }
        //public System.DateTime CAST_DATE_DEBUT_CONTRAT { get; set; }
        //public int CAST_NBR_POSTE { get; set; }
        //public string CAST_DESCRIPTION_POSTE { get; set; }
        //public string CAST_DESCRIPTION_PROFIL { get; set; }
        //public int PRO_ID { get; set; }
        //public int MET_ID { get; set; }

        public override bool Create()
        {
            bool isSucces = this.Update();

            if (isSucces)
            {
                Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Add(this);

                try
                {
                    MegeCastingDatabase.Current.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    Database.MegeCastingDatabase.ReinitializeDatabase();
                    return false;
                }
            }
            else
            {
                Database.MegeCastingDatabase.ReinitializeDatabase();
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
                    MegeCastingDatabase.Current.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    Database.MegeCastingDatabase.ReinitializeDatabase();
                    return false;
                }
            }
            else
            {
                Database.MegeCastingDatabase.ReinitializeDatabase();
                return false;
            }
        }

        public override bool Delete()
        {
            T_E_OFFRE_CASTING_CAST objectSelect = Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Where(x => x.CAST_ID == this.CAST_ID).First();

            Database.MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.Remove(objectSelect);

            try
            {
                MegeCastingDatabase.Current.SaveChanges();
                Database.MegeCastingDatabase.ReinitializeDatabase();
                return true;
            }
            catch (Exception)
            {
                Database.MegeCastingDatabase.ReinitializeDatabase();
                return false;
            }
        }

        public override string GetHeader()
        {
            return this.CAST_ID.ToString();
        }

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_E_OFFRE_CASTING_CAST.ToList().Cast<BaseExtend>().ToList();
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

            TBC = new TextBlock()
            {
                Text = this.T_H_CLIENT_CLI.T_E_PROSPECT_PRO.PRO_NAME,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            TBC = new TextBlock()
            {
                Text = this.T_R_METIER_MET.MET_LIBELLE,
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);


            if (this.T_H_CLIENT_CLI != null)
            {

            }

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

    }
}
