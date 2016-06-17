using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT.Entities {
	class PersonnageMort : Personnage {

		public Episode epMort;

		public PersonnageMort(string nom, string prenom, House maison, int saisonMort, int episodeMort, string sourceImage) : base(nom, prenom, maison, sourceImage) {
			epMort = new Episode(saisonMort, episodeMort);
		}

		public PersonnageMort(string nom, string prenom, House maison, int saisonMort, int episodeMort) : this(nom, prenom, maison, saisonMort, episodeMort, "ImagesHouses/noHouse") {
			epMort = new Episode(saisonMort, episodeMort);
		}
	}
}
