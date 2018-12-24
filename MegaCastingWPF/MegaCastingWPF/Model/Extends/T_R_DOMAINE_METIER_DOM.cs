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
    public partial class T_R_DOMAINE_METIER_DOM : BaseExtend
    {
        public override bool Create()
        {
            bool isSucces = this.Update();

            if (isSucces)
            {
                Database.MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.Add(this);


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
            DomaineMetierEdit windowEdit = new DomaineMetierEdit(this);
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
            T_R_DOMAINE_METIER_DOM objectSelect = Database.MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.Where(x => x.DOM_ID == this.DOM_ID).First();

            Database.MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.Remove(objectSelect);

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
            return this.DOM_ID.ToString();
        }

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.ToList().Cast<BaseExtend>().ToList();
        }

        public override bool IsRelated(string DOMtain = "")
        {
            Boolean related = false;

            if (DOMtain != "")
            {
                foreach (string item in DOMtain.Split(' ').ToList())
                {
                    if (this.DOM_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
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
                Binding = new Binding("DOM_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("DOM_LIBELLE")
            });


            return liste;
        }

        public override string ToString()
        {
            return this.DOM_LIBELLE;
        }
    }
}
