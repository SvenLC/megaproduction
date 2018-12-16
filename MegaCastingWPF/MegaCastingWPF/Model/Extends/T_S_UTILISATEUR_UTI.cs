using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MegaCastingWPF.Database
{
    public partial class T_S_UTILISATEUR_UTI : BaseExtend
    {
        public override bool Create()
        {
            bool isSucces = this.Update();

            Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Add(this);

            if (isSucces)
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

        public override bool Update()
        {
            UtilisateurEdit windowEdit = new UtilisateurEdit(this);
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
            Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Remove(this);

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
            return this.UTI_ID + " - " + this.UTI_LOGIN;
        }

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.ToList().Cast<BaseExtend>().ToList();
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
                Header = "MDP",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("UTI_MDP")
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

    }
}
