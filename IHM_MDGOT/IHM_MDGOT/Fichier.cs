



using IHM_MDGOT.Modeles;
using IHM_MDGOT.ViewModels;
using Métier_MDGOT;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace IHM_MDGOT
{
    public class Fichier
    {
        public void Save(ObservableCollection<PersonnageViewModel> list)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<PersonnageViewModel>));
            using (StreamWriter wr = new StreamWriter("Personnage.xml"))
            {
                xs.Serialize(wr, list);
            }
        
        }

        public void Load()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Personnage>));
            using (StreamReader rd = new StreamReader("Personnage.xml"))
            {
                List<Personnage> perso = xs.Deserialize(rd) as List<Personnage>;
            }
        }
    }
}

