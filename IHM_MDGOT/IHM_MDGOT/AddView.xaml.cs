using IHM_MDGOT;
using IHM_MDGOT.Modeles;
using IHM_MDGOT.ViewModels;
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

namespace IHM_MDGOT {
    /// <summary>
    /// Logique d'interaction pour FenetreAjout.xaml
    /// </summary>
    public partial class AddView : Window {

        private PersonnageViewModel _viewModel;
        public PersonnageViewModel ViewModel {
            get {
                return _viewModel;
            }
            private set {
                _viewModel = value;
            }
        }

        public AddView() {
            InitializeComponent();

            ViewModel = new PersonnageViewModel(new PersonnageModel());
            DataContext = ViewModel;
        }
    }
}
