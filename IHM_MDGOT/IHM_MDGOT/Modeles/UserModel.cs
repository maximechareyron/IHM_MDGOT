using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Modeles
{
    class UserModel
    {
        private string _username;
        public string Username
        {
            get;
            private set;
        }
        private string _email;
        public string Email
        {
            get;
            private set;
        }
        private string _password;
        public string Password
        {
            get;
            private set;
        }
        public UserModel(string nom, string email, string mdp)
        {
            Username = nom;
            Email = email;
            Password = mdp;
        }
        public override string ToString()
        {
            return string.Format("{0}", Username);
        }

    }
}
