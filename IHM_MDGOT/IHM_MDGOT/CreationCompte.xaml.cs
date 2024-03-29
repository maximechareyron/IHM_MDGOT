﻿using IHM_MDGOT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IHM_MDGOT
{
    /// <summary>
    /// Logique d'interaction pour CreationCompte.xaml
    /// </summary>
    public partial class CreationCompte : Window
    {

        public UserViewModel ViewModel { get; set; }
        public CreationCompte()
        {
            ViewModel = new UserViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
