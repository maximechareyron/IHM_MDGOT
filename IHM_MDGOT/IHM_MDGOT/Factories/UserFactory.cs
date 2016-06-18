using IHM_MDGOT.Modeles;
using MétierMDGOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Factories {
    class UserFactory {
        public static UserModel UserEntitiesToUserModel(User user) {
            return new UserModel(user.Username, user.Email, user.Password);
        }

        public static List<UserModel> AllUserEntitiesToUserModel(List<User> list) {
            return list.Select(UserEntitiesToUserModel).ToList<UserModel>();
        }
    }
}
