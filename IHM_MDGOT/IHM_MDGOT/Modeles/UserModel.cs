using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Modeles
{
    public class UserModel : NotifyPropertyChangedBase
    {
        private string _username;
        public string Username
        {
            get {
                return _username;
            }
            set {
                if (value.Equals(null))
                    throw new Exception("Le nom d'utilisateur est un champ indispensable.");
                else {
                _username = value;
                NotifyPropertyChanged("Username");
                }
            }
        }

        private string _email;
        public string Email
        {
            get { 
                return _email;
            }
            set { 
                _email = value;
                NotifyPropertyChanged("Email");
            }
        }

        private string _password;
        public string Password
        {
            get {
                return _password;
            }
            set {
                if (value.Equals(null))
                    throw new Exception("Le mot de passe est un champ obligatoire.");
                else {
                _password = value;
                NotifyPropertyChanged("Password");
                }
            }
        }

        public UserModel(string username, string email, string mdp) {
            try {
            Username = username;
            Email = email;
            Password = mdp;
            } catch (Exception e) {
                Console.WriteLine("Problème lors de la saisie des champs : {0}", e);
            }
        }

        public bool Equals(UserModel user) {
            if (user.Username == this.Username)
                return true;
            if (user.Email == this.Email)
                return true;
            return false;
        }

        public override string ToString() {
            return Username;
        }

    }
}
