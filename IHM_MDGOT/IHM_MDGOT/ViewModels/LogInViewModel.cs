using IHM_MDGOT.Events;
using IHM_MDGOT.Factories;
using IHM_MDGOT.Modeles;
using Library;
using Métier_MDGOT.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace IHM_MDGOT.ViewModels {
    public class LogInViewModel : NotifyPropertyChangedBase {
        public DelegateCommand LogInCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        public DelegateCommand AddUserCommand { get; set; }

        private bool _isLogged;
        public bool IsLogged {
            get {
                return _isLogged;
            }
            set {
                _isLogged = value;
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
                LogInCommand.RaiseCanExecuteChanged();
            }
        }

        private List<UserModel> ListeUsers;

        private CreationCompte _fenetreAjoutUser;

        public LogInViewModel() {
            LogInCommand = new DelegateCommand(OnLogInCommand, CanExecuteCommand);
            CancelCommand = new DelegateCommand(OnCancelCommand);
            AddUserCommand = new DelegateCommand(OnAddUserCommand, CanExecuteCommand);
            User = new UserModel(null, null, null);
            ListeUsers = UserFactory.AllUserEntitiesToUserModel(UserDAO.GetAllUser());
            _isLogged = false;
        }


        private void CloseAddUserView(object sender, EventArgs e) {
            _fenetreAjoutUser.Close();
            ButtonPressedEvent.GetEvent().Handler -= CloseAddUserView;
        }

        public void OnLogInCommand(object obj) {
            if (User.Username == null || User.Username == "" || User.Password == null || User.Password == "") {
                MessageBox.Show("Vous n'avez pas renseigné le nom d'utilisateur et/ou le mot de passe");
                return;
            }
            foreach (UserModel u in ListeUsers) {
                if (u.Username.Equals(User.Username) && u.Password.Equals(User.Password)) {
                    MessageBox.Show("Vous êtes maintenant connecté.");
                    IsLogged = true;
                    ButtonPressedEvent.GetEvent().OnButtonPressedHandler(EventArgs.Empty);
                } else {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe incorrect(s).");
                }
            }
        }

        

        public void OnCancelCommand(object obj) {
            ButtonPressedEvent.GetEvent().OnButtonPressedHandler(EventArgs.Empty);
        }

        public void OnAddUserCommand(object obj) {
            ButtonPressedEvent.GetEvent().Handler += CloseAddUserView;

            _fenetreAjoutUser = new CreationCompte();
            _fenetreAjoutUser.ShowDialog();

            if (_fenetreAjoutUser.ViewModel.IsSaisieValid) {
                ListeUsers.Add(_fenetreAjoutUser.ViewModel.User);
            }
        }

        public bool CanExecuteCommand(Object o) {
            return true;
        }

    }

}
