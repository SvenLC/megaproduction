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
    public partial class T_E_CONTACT_CTC : BaseExtend
    {
        public override bool IsRelated(string contain = "")
        {
            Boolean related = false;

            if (contain != "")
            {
                if (this.PRO_ID.ToString() == contain)
                    related = true;
            }


            return related;
        }

        public override string GetHeader()
        {
            throw new NotImplementedException();
        }

        public override List<TextBlock> PreviewGroupBox()
        {
            throw new NotImplementedException();
        }

        public override List<DataGridColumn> previewList()
        {
            List<DataGridColumn> liste = new List<DataGridColumn>();

            liste.Add(new DataGridTextColumn()
            {
                Header = "Id",
                Width = new DataGridLength(50),
                FontSize = 12,
                Binding = new Binding("CTC_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Description",
                Width = new DataGridLength(150),
                FontSize = 12,
                Binding = new Binding("CTC_DESCRIPTION")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Email",
                Width = new DataGridLength(200),
                FontSize = 12,
                Binding = new Binding("CTC_EMAIL")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Fax",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_NUM_FAX")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Téléphone",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_NUM_TEL")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Principale",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("CTC_PRINCIPALE")
            });

            return liste;
        }

        public override bool Create()
        {
            bool isSucces = this.Update();

            if (isSucces)
            {
                try
                {
                    if (this.PRO_ID != 0)
                    {
                        Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.Where(x => x.PRO_ID == this.PRO_ID).First().T_E_CONTACT_CTC.Add(this);
                    }
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
            ContactEdit windowEdit = new ContactEdit(this);
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
            Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.Remove(this);

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

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_E_CONTACT_CTC.ToList().Cast<BaseExtend>().ToList();
        }

    }
}
