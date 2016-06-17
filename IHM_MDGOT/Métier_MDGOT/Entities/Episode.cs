using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier_MDGOT {
	class Episode {
		private int _saison;
		private int _numero;

		public Episode(int saison, int numero) {
			_saison = saison;
			_numero = numero;
		}

		public override string ToString() {
			return string.Format("S{0}E{1}", _saison, _numero);
		}
	}
}
