﻿using MegaCastingWPF.Model.Extends;
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
    public partial class T_R_LOCALISATION_LOC : BaseExtend
    {
        public override bool Create()
        {
            bool isSucces = this.Update();

            if (isSucces)
            {
                Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Add(this);


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
            LocalisationEdit windowEdit = new LocalisationEdit(this);
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
            T_R_LOCALISATION_LOC objectSelect = Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Where(x => x.LOC_ID == this.LOC_ID).First();

            Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.Remove(objectSelect);

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
            return this.LOC_ID.ToString();
        }

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.ToList().Cast<BaseExtend>().ToList();
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


    }
}
