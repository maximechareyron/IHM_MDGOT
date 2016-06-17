using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace IHM_MDGOT.Modeles {
    class User {
        private string _username;
        public string Username {
            get;
            private set;
        }
        private string _password;
        public string Password {
            get;
            private set;
        }
    }
}

