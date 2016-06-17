using IHM_MDGOT.Events;
using IHM_MDGOT.Factories;
using IHM_MDGOT.Modeles;
using Library;
using Métier_MDGOT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.ViewModels {
    public class PersonnageViewModel : NotifyPropertyChangedBase {
        public DelegateCommand ValidateCommand { get; set; }

        public DelegateCommand CancelCommand { get; set; }

        private PersonnageModel _personnage;

        private bool _isSaisieValid=false;

        public House ListeMaison;

        public PersonnageModel Personnage {
            get {
                return _personnage;
            }
            set {
                _personnage = value;
                NotifyPropertyChanged("Personnage");
                ValidateCommand.RaiseCanExecuteChanged();
            }
        }

        public bool IsSaisieValid {
            get {
                return _isSaisieValid;
            }
            set {
                _isSaisieValid = value;
            }
        }

        public PersonnageViewModel(PersonnageModel perso) {
            ValidateCommand = new DelegateCommand(OnValidateCommand, CanExecuteValidate);
            CancelCommand = new DelegateCommand(OnCancelCommand, CanExecuteCancel);
            Personnage = perso;
        }

        private void OnValidateCommand(object o) {
            IsSaisieValid = true;
            ButtonPressedEvent.GetEvent().OnButtonPressedHandler(EventArgs.Empty);
        }

        private void OnCancelCommand(object o) {
            IsSaisieValid = false;
            ButtonPressedEvent.GetEvent().OnButtonPressedHandler(EventArgs.Empty);
        }


        private bool CanExecuteValidate(object o) {
            //return (Personnage.Nom != null);
            return true;
        }

        private bool CanExecuteCancel(object o) {
            return true;
        }
    }
}
