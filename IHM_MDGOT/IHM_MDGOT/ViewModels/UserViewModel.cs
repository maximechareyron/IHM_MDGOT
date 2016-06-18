using IHM_MDGOT.Events;
using IHM_MDGOT.Modeles;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.ViewModels {
    public class UserViewModel : NotifyPropertyChangedBase {
        public DelegateCommand ValidateCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }


        private bool _isSaisieValid = false;
        public bool IsSaisieValid {
            get {
                return _isSaisieValid;
            }
            set {
                _isSaisieValid = value;
            }
        }


        private UserModel _user;

        public UserModel User {
            get {
                return _user;
            }
            set {
                _user = value;
                NotifyPropertyChanged("User");
                ValidateCommand.RaiseCanExecuteChanged();
            }
        }

        public UserViewModel() {
            ValidateCommand = new DelegateCommand(OnValidateCommand, CanExecuteValidate);
            CancelCommand = new DelegateCommand(OnCancelCommand, CanExecuteCancel);
            User = new UserModel("", "", "");
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
            return (User.Username != null && User.Password != null);
        }

        private bool CanExecuteCancel(object o) {
            return true;
        }


    }
}
