using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHM_MDGOT.Modeles
{
    public class House : NotifyPropertyChangedBase
    {

        public string Nom { get; set; }

        public string ImageSource { get; set; }


        public House(string nom, string imgSource)
        {
            Nom = nom;
            ImageSource = imgSource;
        }

        public override string ToString()
        {
            return string.Format("{0}", Nom);
        }
    }
}
