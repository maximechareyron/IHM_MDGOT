using IHM_MDGOT.Events;
using IHM_MDGOT.Factories;
using IHM_MDGOT.Modeles;
using Library;
using Métier_MDGOT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IHM_MDGOT.ViewModels {
    public class ListPersonnagesViewModel : NotifyPropertyChangedBase {
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand EditCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand SearchCommand { get; set; }
        public DelegateCommand KillCommand { get; set; }
        public DelegateCommand ComeBackCommand { get; set; }

        public String Recherche { get; set; }

        private PersonnageModel _personnage;

        private AddView _fenetreAjoutPerso;
        private EditView _fenetreEditionPerso;


        public PersonnageModel Personnage {
            get {
                return _personnage;
            }
            set {
                _personnage = value;
                NotifyPropertyChanged("Personnage");
                NotifyPropertyChanged("ListePersonnageAffich");
                EditCommand.RaiseCanExecuteChanged();
                DeleteCommand.RaiseCanExecuteChanged();
                SearchCommand.RaiseCanExecuteChanged();
                KillCommand.RaiseCanExecuteChanged();
                ComeBackCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<PersonnageModel> _listePersonnages;
        public ObservableCollection<PersonnageModel> ListePersonnages {
            get {
                return _listePersonnages;
            }
            set {
                _listePersonnages = value;
                _listePersonnages = TrierListe(_listePersonnages);
            }
        }

        private ObservableCollection<PersonnageModel> _listePersonnageAffich;
        public ObservableCollection<PersonnageModel> ListePersonnageAffich {
            get {
                return _listePersonnageAffich;
            }
            set {
                _listePersonnageAffich = value;
                _listePersonnageAffich = TrierListe(_listePersonnageAffich);
                NotifyPropertyChanged("ListePersonnageAffich");
            }
        }

        public ListPersonnagesViewModel() {
            ListePersonnages = PersonnageFactory.AllPersonnageEntitieToPersonnageModele(PersonnageDAO.GetAllPersonnage());
            ListePersonnageAffich = ListePersonnages;

            AddCommand = new DelegateCommand(OnAddCommand, CanExecuteAdd);
            EditCommand = new DelegateCommand(OnEditCommand, CanExecuteIfPersoSelected);
            DeleteCommand = new DelegateCommand(OnDeleteCommand, CanExecuteIfPersoSelected);
            SearchCommand = new DelegateCommand(OnSearchCommand, CanExecuteSearch);
            KillCommand = new DelegateCommand(OnKillCommand, CanExecuteIfPersoSelected);
            ComeBackCommand = new DelegateCommand(OnComeBackCommand, CanExecuteIfPersoSelected);

        }

        public ObservableCollection<PersonnageModel> Rechercher() {
            ObservableCollection<PersonnageModel> oc = new ObservableCollection<PersonnageModel>();
            string prenom = "";
            string nom = "";
            if (Recherche != null) Recherche = Recherche.ToLower();
            foreach (PersonnageModel perso in ListePersonnages) {
                if (perso.Prenom != null) prenom = perso.Prenom.ToLower();
                if (perso.Nom != null) nom = perso.Nom.ToLower();
                if (prenom.Contains(Recherche) || nom.Contains(Recherche)) oc.Add(perso);
            }
            return oc;
        }

        private void CloseAddView(object sender, EventArgs e) {
            _fenetreAjoutPerso.Close();
            ButtonPressedEvent.GetEvent().Handler -= CloseAddView;
        }

        private void CloseEditView(object sender, EventArgs e) {
            _fenetreEditionPerso.Close();
            ButtonPressedEvent.GetEvent().Handler -= CloseEditView;
        }

        private ObservableCollection<PersonnageModel> TrierListe(ObservableCollection<PersonnageModel> li) {
            return new ObservableCollection<PersonnageModel>(li.OrderBy(x => x.Prenom));
        }

        private void OnAddCommand(object o) {
            ButtonPressedEvent.GetEvent().Handler += CloseAddView;

            _fenetreAjoutPerso = new AddView();
            _fenetreAjoutPerso.Name = "Ajout";
            _fenetreAjoutPerso.ShowDialog(); //actif tant que la fenetre est ouverte.

            if (_fenetreAjoutPerso.ViewModel.IsSaisieValid) {
                ListePersonnages.Add(_fenetreAjoutPerso.ViewModel.Personnage);
                ListePersonnages = TrierListe(ListePersonnages); // Supprimable ? (la liste qui n'est pas affichée n'a techniquement pas besoin d'être triée)
                ListePersonnageAffich = ListePersonnages;
                //NotifyPropertyChanged("ListePersonnageAffich"); //Ajouté dans le setter de ListePersonnageAffich
            }
        }

        private void OnEditCommand(object o) {
            ButtonPressedEvent.GetEvent().Handler += CloseEditView;

            _fenetreEditionPerso = new EditView(Personnage);
            _fenetreEditionPerso.Name = "Modifier";
            _fenetreEditionPerso.ShowDialog();

            if (_fenetreEditionPerso.ViewModel.IsSaisieValid) {
                ListePersonnages.Remove(Personnage);
                ListePersonnages.Add(_fenetreEditionPerso.ViewModel.Personnage);
                ListePersonnages = TrierListe(ListePersonnages); // Supprimable ?
                ListePersonnageAffich = ListePersonnages;
            }
        }


        private void OnDeleteCommand(object o) {
            ListePersonnages.Remove(Personnage);
            ListePersonnageAffich = ListePersonnages;
        }

        private void OnSearchCommand(object o) {
            ObservableCollection<PersonnageModel> oc = Rechercher();
            if (oc == null) return;
            ListePersonnageAffich = oc;
        }

        private void OnKillCommand(object o){
            PersonnageModel perso = Personnage;
            perso.Etat = Etat.Mort;
            ListePersonnages.Remove(Personnage);
            ListePersonnages.Add(perso);
            ListePersonnageAffich = ListePersonnages;
        }

        private void OnComeBackCommand(object o) {
            Personnage.Etat = Etat.Vivant;
            NotifyPropertyChanged("Personnage");
        }

        private bool CanExecuteAdd(object o) {
            return true;
        }

        private bool CanExecuteSearch(Object o) {
            //return (Recherche != null && Recherche != "");
            return true;
        }

        private bool CanExecuteIfPersoSelected(Object o) {
            return Personnage != null;
        }

    }
}
