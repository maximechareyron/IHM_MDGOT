using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
    public class Personnage {
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public House Maison { get; set; }

        //    public string Description { get; set;  }

        public Personnage(string nom, string prenom, string maison) {
            Nom = nom;
            Prenom = prenom;
            Maison = (House) Enum.Parse(typeof(House), maison, true);
            //    Description = description;
        }

        public Personnage(string nom, string prenom) : this(nom, prenom, "NoHouse") { }

    }
}
