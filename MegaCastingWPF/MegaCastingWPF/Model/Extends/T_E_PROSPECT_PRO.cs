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
    public partial class T_E_PROSPECT_PRO : BaseExtend
    {
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

            if (this.T_H_PARTENAIRES_PAR != null)
            {
                TBC = new TextBlock()
                {
                    Text = "Partenaire",
                    FontWeight = FontWeight.FromOpenTypeWeight(750)
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_PARTENAIRES_PAR.PAR_LOGIN
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);
            }

            if (this.T_H_CLIENT_CLI != null)
            {
                TBC = new TextBlock()
                {
                    Text = "Client",
                    FontWeight = FontWeight.FromOpenTypeWeight(750)
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.T_R_STATUT_JURIDIQUE_JUR.ToString()
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.CLI_RNA.ToString()
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.CLI_SIRET.ToString()
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = "Adresse",
                    FontWeight = FontWeight.FromOpenTypeWeight(750)
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_NUM_VOIE
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_LIBELLE_RUE
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);

                TBC = new TextBlock()
                {
                    Text = this.T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_VILLE
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                liste.Add(TBC);
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
                Binding = new Binding("T_H_CLIENT_CLI.CLI_RNA")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "SIRET",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_H_CLIENT_CLI.CLI_SIRET")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Numéro",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_NUM_VOIE")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Libellé de la rue",
                Width = new DataGridLength(300),
                FontSize = 12,
                Binding = new Binding("T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_LIBELLE_RUE")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Ville",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_H_CLIENT_CLI.T_E_ADRESSE_ADR.ADR_VILLE")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Utilisateur",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("T_H_PARTENAIRES_PAR.PAR_LOGIN")
            });

            return liste;
        }

        public override bool Create()
        {
            bool isSucces = this.Update();

            if (isSucces)
            {
                Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Add(this);

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
            ProspectEdit windowEdit = new ProspectEdit(this);
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
            T_E_PROSPECT_PRO objectSelect = Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Where(x => x.PRO_ID == this.PRO_ID).First();


            if (objectSelect.T_H_CLIENT_CLI != null)
            {

                if (!objectSelect.T_H_CLIENT_CLI.T_E_OFFRE_CASTING_CAST.Any())
                {
                    Database.MegeCastingDatabase.Current.T_H_CLIENT_CLI.Remove(objectSelect.T_H_CLIENT_CLI);
                }
                else
                {
                }

            }
            if (objectSelect.T_H_PARTENAIRES_PAR != null)
            {
                Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.Remove(objectSelect.T_H_PARTENAIRES_PAR);
            }

            if (objectSelect.T_E_CONTACT_CTC.Count > 0)
            {
                foreach (T_E_CONTACT_CTC item in objectSelect.T_E_CONTACT_CTC.ToList())
                {
                    Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Remove(item);
                }
            }

            Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Remove(objectSelect);

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

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_E_PROSPECT_PRO.ToList().Cast<BaseExtend>().ToList();
        }

    }
}
