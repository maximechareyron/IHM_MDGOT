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

        private House _maison;
        public House Maison { 
            get { 
                return _maison;
            }
            set {
                _maison = value; NotifyPropertyChanged("Maison");
            }
        }

        public string ImageMaison {
            get {
                return string.Format("/Métier_MDGOT;component/ImagesHouses/{0}", Enum.GetName(typeof(House), Maison).ToLower());
            }
            set { }
        }

		
        /*
		private string _portrait;
		public string Portrait {
			get {
				return _portrait;
			}
			set {
				_portrait = value;
			}
		}
         * */

		public override string ToString() {
			return string.Format("{0} {1}", Prenom, Nom);
		}

	}
}
