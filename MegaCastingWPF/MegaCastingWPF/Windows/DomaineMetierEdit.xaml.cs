﻿using MahApps.Metro.Controls;
using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Model.Views.Edit;
using MegaCastingWPF.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MegaCastingWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour ContactEdit.xaml
    /// </summary>
    public partial class DomaineMetierEdit : MetroWindow
    {
        DomaineMetierEditModel Model;

        public DomaineMetierEdit(T_R_DOMAINE_METIER_DOM _Prospect = null)
        {
            InitializeComponent();

            Model = new DomaineMetierEditModel(_Prospect);

            this.DataContext = Model;
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
