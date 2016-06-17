using IHM_MDGOT.Extension;
using IHM_MDGOT.Modeles;
using Métier_MDGOT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Factories {
    class HouseFactory {
        public static HouseModel HousesEntitiesToHousesModele(House house) {
			if (house != null) {
				return new HouseModel {
					Nom = house.Nom,
					Blason = house.Blason,
				};
			}
			return null;
        }

        public static ObservableCollection<HouseModel> AllHouseEntitieToHouseModele(List<House> list) {
            return list.Select(HousesEntitiesToHousesModele).ToList<HouseModel>().ToObservableCollection<HouseModel>();
        }
    }
}
