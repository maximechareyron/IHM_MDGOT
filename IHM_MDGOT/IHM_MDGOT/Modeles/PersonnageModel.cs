using Library;
using Métier_MDGOT;
using Métier_MDGOT.Entities;
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
                _maison = value;
                NotifyPropertyChanged("Maison");
            }
        }

        private string _description;
        public string Description {
            get {
                return _description;
            }
            set {
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        private Etat _etat;
        public Etat Etat {
            get {
                return _etat;
            }
            set {
                _etat = value;
                NotifyPropertyChanged("Etat");
            }
        }

        private string _imageMaison;
        public String ImageMaison {
            get {
                return string.Format("/Métier_MDGOT;component/ImagesHouses/{0}.{1}", Enum.GetName(typeof(House), Maison).ToLower(), "jpg");
            }
            set {
                _imageMaison = string.Format("/Métier_MDGOT;component/ImagesHouses/{0}.{1}", Enum.GetName(typeof(House), Maison).ToLower(), "jpg");
                NotifyPropertyChanged("ImageMaison");
            }
        }

		public override string ToString() {
			return string.Format("{0} {1}", Prenom, Nom);
		}

	}
}
