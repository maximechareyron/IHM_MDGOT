using IHM_MDGOT.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Events {
    public class PersonnageModelEventArgs : EventArgs{
        public PersonnageModel Perso { get; set; }

        public PersonnageModelEventArgs(PersonnageModel perso) {
            Perso = perso;
        }
    }
}
