using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
	public class House {

		public string Nom { get; set; }

		public string Blason { get; set; }

		public House(string nom, string sourceImage) {
			Nom = nom;
            Blason = sourceImage;
		}

		public House(string nom) : this(nom, @"C:\Users\maxim\Source\Repos\MasterDetailGOT\IHM_MDGOT\Métier_MDGOT\ImagesHouses\noHouse.jpg") { }
	}
}
