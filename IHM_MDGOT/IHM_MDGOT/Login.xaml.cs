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

namespace IHM_MDGOT {
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window {
        public LogInViewModel ViewModel;

        public Login()
        {
            InitializeComponent();

            ViewModel = new LogInViewModel();
            DataContext = ViewModel; { }
        }
    }
}
