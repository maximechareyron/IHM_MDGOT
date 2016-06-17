using Library;
using Métier_MDGOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM_MDGOT.Modeles {
	public class PersonnageModel : NotifyPropertyChangedBase{
		private string _nom;
		public string Nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
				NotifyPropertyChanged("Nom");
			}
		}

		private string _prenom;
		public string Prenom {
			get {
				return _prenom;
			}
			set {
				_prenom = value;
				NotifyPropertyChanged("Prenom");
			}
		}

		private HouseModel _house;
		public HouseModel House {
			get {
				return _house;
			}
			set {
				_house = value;
				NotifyPropertyChanged("House");
			}
		}

		private string _portrait;
		public string Portrait {
			get {
				return _portrait;
			}
			set {
				_portrait = value;
			}
		}

		public override string ToString() {
			return string.Format("{0} {1}", Prenom, Nom);
		}

	}
}
