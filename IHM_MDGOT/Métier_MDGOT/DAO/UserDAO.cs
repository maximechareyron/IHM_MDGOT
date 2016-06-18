using MétierMDGOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Métier_MDGOT.DAO {
    public class UserDAO {
        public static List<User> GetAllUser() {
            List<User> li = new List<User>();
            li.Add(new User("root", "toor"));
            return li;
        }
    }
}
