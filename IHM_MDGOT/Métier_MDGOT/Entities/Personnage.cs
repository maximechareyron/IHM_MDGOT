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

		public string Portrait { get; set; }

    //    public string Description { get; set;  }

		public Personnage(string nom, string prenom, House maison, string sourceImage) {
			Nom = nom;
			Prenom = prenom;
			Maison = maison;
            Portrait = sourceImage;
        //    Description = description;
		}

		public Personnage(string nom, string prenom, House maison) : this(nom, prenom, maison, "ImagesHouses/noHouse.jpg") { }

		public Personnage(string nom, string prenom, string sourceImage) : this(nom, prenom, null, sourceImage) { }

		public Personnage(string nom, string prenom) : this(nom, prenom, null, "ImagesHouses/noHouse.jpg") { }

	}
}
