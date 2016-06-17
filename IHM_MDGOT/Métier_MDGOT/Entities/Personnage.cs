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

        public string Description { get; set; }

        public Etat Etat { get; set; }

        public Personnage(string nom, string prenom, string maison, string description, string etat) {
            Nom = nom;
            Prenom = prenom;
            Maison = (House) Enum.Parse(typeof(House), maison, true);
            Description = description;
            Etat = (Etat)Enum.Parse(typeof(Etat), etat, true);
        }

        public Personnage(string nom, string prenom, string maison) : this(nom, prenom, maison, null, "Inconnu") { }

        public Personnage(string nom, string prenom) : this(nom, prenom, "NoHouse", null, "Inconnu") { }

    }
}
