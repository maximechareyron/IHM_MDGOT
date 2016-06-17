using Métier_MDGOT.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
	public class PersonnageDAO {
		public static List<Personnage> GetAllPersonnage() {
			List<Personnage> li = new List<Personnage>();
			li.Add(new Personnage("Stark", "Arya", new House("Stark", @"C:\Users\maxim\Source\Repos\MasterDetailGOT\IHM_MDGOT\Métier_MDGOT\ImagesHouses\stark.jpg")));
            li.Add(new Personnage("Stark", "Ned"));
            li.Add(new Personnage("Stark", "Caitlyn"));
            li.Add(new Personnage("Stark", "Rob"));
            li.Add(new Personnage("Stark", "Bran"));
            li.Add(new Personnage("Stark", "Sansa"));
			li.Add(new Personnage("Lannister", "Cersei"));
			li.Add(new Personnage("Lannister", "Tommen"));
			li.Add(new Personnage("Lannister", "Jaime"));
			li.Add(new Personnage("Lannister", "Geoffrey"));
			return li;
		}
	}
}
