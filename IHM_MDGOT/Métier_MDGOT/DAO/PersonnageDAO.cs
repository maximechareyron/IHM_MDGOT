using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
	public class PersonnageDAO {
		public static List<Personnage> GetAllPersonnage() {
            return lectureFichier("got.txt");
		}

        public static List<Personnage> lectureFichier(string nomFic) {
            List<Personnage> ListePersos = new List<Personnage>();
            StreamReader reader = new StreamReader(string.Format("../../../Métier_MDGOT/Saves/{0}", nomFic));
            string ligne = reader.ReadLine();
            int nbElem;
            if (ligne == null)
                nbElem = 0;
            else
                nbElem = int.Parse(ligne);
            for (int i = 0; i < nbElem; i++) {
                Personnage p = new Personnage {
                    Nom = reader.ReadLine(),
                    Prenom = reader.ReadLine(),
                    Maison = (House)Enum.Parse(typeof(House), reader.ReadLine(), true),
                    Description = reader.ReadLine(),
                    Etat = (Etat)Enum.Parse(typeof(Etat), reader.ReadLine(), true)
                };
                ListePersos.Add(p);
            }
            reader.Close();
            return ListePersos;

        }
	}
}
