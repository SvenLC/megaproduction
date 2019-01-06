using MegaCastingWPF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegaCastingWPF.Model.Extends
{
    public abstract class BaseExtend : ICrud
    {

        public abstract bool IsRelated(string contain = "");

        public abstract string GetHeader();

        public abstract List<BaseExtend> getSource();

        public abstract List<TextBlock> PreviewGroupBox();

        public abstract List<DataGridColumn> previewList();

        public abstract bool Create();

        public abstract bool Update();

        public abstract bool Delete();

    }
}
