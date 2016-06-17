using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
	public class PersonnageDAO {
		public static List<Personnage> GetAllPersonnage() {
			List<Personnage> li = new List<Personnage>();
			li.Add(new Personnage("Stark", "Arya", "Stark"));
            li.Add(new Personnage("Stark", "Ned", "Stark"));
            li.Add(new Personnage("Stark", "Caitlyn", "Stark"));
            li.Add(new Personnage("Stark", "Rob", "Stark"));
            li.Add(new Personnage("Stark", "Bran", "Stark"));
            li.Add(new Personnage("Stark", "Sansa", "Stark"));
			li.Add(new Personnage("Lannister", "Cersei", "Lannister"));
			li.Add(new Personnage("Lannister", "Tommen", "Lannister"));
			li.Add(new Personnage("Lannister", "Jaime", "Lannister"));
			li.Add(new Personnage("Lannister", "Geoffrey", "Lannister"));
            li.Add(new Personnage("Tyrell", "Loras", "Tyrell"));
            li.Add(new Personnage("Targaryen", "Daenerys", "Targaryen"));
            li.Add(new Personnage("Targaryen", "Viserys", "Targaryen"));

			return li;
		}
	}
}
