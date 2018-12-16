using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MegaCastingWPF.Database
{
    public partial class T_R_METIER_MET : BaseExtend
    {
        public override bool Create()
        {
            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override string GetHeader()
        {
            return this.MET_ID.ToString();
        }

        public override List<BaseExtend> getSource()
        {
            return MegeCastingDatabase.Current.T_R_METIER_MET.ToList().Cast<BaseExtend>().ToList();
        }

        public override bool IsRelated(string LOCtain = "")
        {
            Boolean related = false;

            if (LOCtain != "")
            {
                foreach (string item in LOCtain.Split(' ').ToList())
                {
                    if (this.MET_LIBELLE.ToLower().Contains(item.ToLower()) && item != "")
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
                Text = this.MET_LIBELLE
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
                Binding = new Binding("MET_ID")
            });

            liste.Add(new DataGridTextColumn()
            {
                Header = "Login",
                Width = new DataGridLength(100),
                FontSize = 12,
                Binding = new Binding("MET_LIBELLE")
            });


            return liste;
        }

        public override bool Update()
        {
            throw new NotImplementedException();
        }

    }
}
