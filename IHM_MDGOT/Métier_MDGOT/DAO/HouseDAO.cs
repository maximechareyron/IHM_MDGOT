using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Controls;

namespace Métier_MDGOT.DAO {
	public class HouseDAO {
		public static List<House> GetAllHouse() {
			List<House> li = new List<House>();

            li.Add(new House("Aucune", "/Métier_MDGOT;component/ImagesHouses/noHouse.jpg"));
            li.Add(new House("Arryn", "/Métier_MDGOT;component/ImagesHouses/arryn.jpg"));
            li.Add(new House("Baratheon", "/Métier_MDGOT;component/ImagesHouses/baratheon.jpg"));
            li.Add(new House("Clegane", "/Métier_MDGOT;component/ImagesHouses/clegane.jpg"));
            li.Add(new House("Greyjoy", "/Métier_MDGOT;component/ImagesHouses/greyjoy.jpg"));
            li.Add(new House("Lannister", "/Métier_MDGOT;component/ImagesHouses/lannister.jpg"));
            li.Add(new House("Mormont", "/Métier_MDGOT;component/ImagesHouses/mormont.jpg"));
            li.Add(new House("Stark", "/Métier_MDGOT;component/ImagesHouses/stark.jpg"));
            li.Add(new House("Targaryen", "/Métier_MDGOT;component/ImagesHouses/targaryen.jpg"));
            li.Add(new House("Tully", "/Métier_MDGOT;component/ImagesHouses/tully.jpg"));
            li.Add(new House("Tyrell", "/Métier_MDGOT;component/ImagesHouses/tyrell.jpg"));
			return li;
		}
	}
}
