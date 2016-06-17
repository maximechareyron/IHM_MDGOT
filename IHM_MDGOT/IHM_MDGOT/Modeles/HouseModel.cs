using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Modeles {
    public class HouseModel {
        public string _nom;
        public string Nom {
            get {
                return _nom;
            }
            set {
                _nom = value;
            }
        }
        public string _blason;
        public string Blason {
            get {
                return _blason;
            }
            set {
                _blason = value;
            }
        }

        public override string ToString() {
            return Nom;
        }

    }
}
