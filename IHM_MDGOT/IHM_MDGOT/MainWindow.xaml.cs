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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using IHM_MDGOT.ViewModels;
using Microsoft.Win32;

namespace IHM_MDGOT {
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ListPersonnagesViewModel _viewModel;
        //MediaPlayer sound;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new ListPersonnagesViewModel();
            DataContext = _viewModel;
            /*sound = new MediaPlayer();
            sound.Open(new Uri(@"../../Music/GOT.mp3", UriKind.Relative));
            sound.Play();
            */
        }
    }
}
