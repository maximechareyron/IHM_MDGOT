using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Métier_MDGOT.Entities
{
    class User
    {
        public string Username
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public User(string nom, string email, string mdp)
        {
            Username = nom;
            Email = email;
            Password = mdp;
        }
    }
}
