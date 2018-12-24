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
            return this.PRO_ID.ToString();
        }

        public override List<TextBlock> PreviewGroupBox()
        {
            List<TextBlock> liste = new List<TextBlock>();

            TextBlock TBC = new TextBlock()
            {
                Text = this.PRO_NAME
            };

            TBC.SetValue(Grid.ColumnProperty, 0);

            liste.Add(TBC);

            return liste;
        }

        public override List<DataGridTextColumn> previewList()
        {
            List<DataGridTextColumn> liste = new List<DataGridTextColumn>();

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

        public override bool Create() => Update();


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
            throw new NotImplementedException();
        }
    }
}
