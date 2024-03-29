﻿using IHM_MDGOT.Extension;
using IHM_MDGOT.Modeles;
using Métier_MDGOT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM_MDGOT.Factories {
	public class PersonnageFactory {

		public static PersonnageModel PersonnagesEntitiesToPersonagesModele(Personnage perso) {
			return new PersonnageModel {
				Nom = perso.Nom,
				Prenom = perso.Prenom,
				Maison = perso.Maison,
				Etat = perso.Etat,
                Description = perso.Description
			};
		}

		public static ObservableCollection<PersonnageModel> AllPersonnageEntitieToPersonnageModele(List<Personnage> list) {
			return list.Select(PersonnagesEntitiesToPersonagesModele).ToList<PersonnageModel>().ToObservableCollection<PersonnageModel>();
		}
	}
}
