using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace MétierMDGOT.Entities {
    public class User {
        public string Username{get;set;}

        public string Email{get;set;}
        
        public string Password{get;set;}

        public User(string username, string email, string password) {
            Username = username;
            Email = email;
            Password = password;
        }

        public User(string username, string password) : this(username, null, password) { }
    }
}
