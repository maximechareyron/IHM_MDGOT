using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM_MDGOT
{
    public class Maison
    {
        String Nom_Maison
        {
            get;
            set;
        }

        public string ImgSource
        {
            get;
            set;
        }
        public Maison(String Maison, String imageSource)
        {
            Nom_Maison = Maison;
            ImgSource = imageSource;
        }
    }

}