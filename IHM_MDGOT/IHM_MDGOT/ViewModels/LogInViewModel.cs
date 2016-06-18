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

        private MainWindow _fenetrePrincipale;
        private CreationCompte _fenetreAjoutUser;

        public LogInViewModel() {
            LogInCommand = new DelegateCommand(OnLogInCommand, CanExecuteCommand);
            CancelCommand = new DelegateCommand(OnCancelCommand);
            AddUserCommand = new DelegateCommand(OnAddUserCommand, CanExecuteCommand);
            ListeUsers = UserFactory.AllUserEntitiesToUserModel(UserDAO.GetAllUser());

        }

        private void CloseMainView(object sender, EventArgs e) {
            _fenetrePrincipale.Close();
            ButtonPressedEvent.GetEvent().Handler -= CloseMainView;
        }

        private void CloseAddUserView(object sender, EventArgs e) {
            _fenetreAjoutUser.Close();
            ButtonPressedEvent.GetEvent().Handler -= CloseAddUserView;
        }

        public void OnLogInCommand(object obj) {
            foreach (UserModel u in ListeUsers) {
                if (u.Username.Equals(User.Username) && u.Password.Equals(User.Password)) {
                    ButtonPressedEvent.GetEvent().Handler += CloseMainView;
                    _fenetrePrincipale = new MainWindow();
                    
                }
            }
            MessageBox.Show("Login et/ou mot de passe incorrect(s).");

        }

        

        public void OnCancelCommand(object obj) {


        }

        public void OnAddUserCommand(object obj) {
            
        }

        public bool CanExecuteCommand(Object o) {
            return true;
        }






        public bool EmailValid(string email) {
            try {
                MailAddress mail = new MailAddress(email);

                return true;
            } catch (FormatException) {
                return false;
            }
        }




        private string CalculateHash(string clearTextPassword, string us) {
            // Convertie le mdp en mode byte
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(clearTextPassword + us);
            // Use the hash algorithm to calculate the hash
            HashAlgorithm algorithme = new SHA256Managed();
            byte[] hash = algorithme.ComputeHash(saltedHashBytes);
            // Return the hash as a base64 encoded string to be compared to the stored password
            return Convert.ToBase64String(hash);
        }

    }

}
