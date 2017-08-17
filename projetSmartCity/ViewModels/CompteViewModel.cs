using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using projetSmartCity.DAO;
using projetSmartCity.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;

namespace projetSmartCity.ViewModels
{
    public class CompteViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ICommand _goToMainPageCommand;
        private INavigationService _navigationService;
        private ICommand _goToModification;

        [PreferredConstructor]
        public CompteViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
            InitializeAsync();
            
            var service = new UtilisateurService();
      
        }
        public void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        public async Task InitializeAsync()
        {
            var service = new UtilisateurService();
            var user = await service.GetUtilisateur();
            
            Nom = user.Nom;
            Prenom = user.Prenom;
            Date_de_Naissance = user.Date_de_Naissance;
            Adr_Numero_de_rue = user.Adr_Numero_de_rue;
            Adr_Nom_de_Rue = user.Adr_Nom_de_Rue;
            Adr_Code_Postal = user.Adr_Code_Postal;
            Adr_Localite = user.Adr_Localite;
            Adresse_mail = user.Email;
            Numero_de_Telephone = user.Numero_de_Telephone;
        }
       

        public ICommand GoToMainPageCommand
        {
            get
            {
                if (_goToMainPageCommand == null)
                    _goToMainPageCommand = new RelayCommand(() => GoToMainPage());
                return _goToMainPageCommand;
            }
        }
        private void GoToMainPage()
        {
            _navigationService.NavigateTo("MainPage");
        }

        private string _adresse_mail;
        public string Adresse_mail
        {
            get
            {
                return _adresse_mail;
            }
            set
            {
                _adresse_mail = value;
                RaisePropertyChanged("Adresse_mail");
            }
        }
        private string _nom;
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                RaisePropertyChanged("Nom");
            }
        }
        private string _prenom;
        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
                RaisePropertyChanged("Prenom");
            }
        }
        private DateTimeOffset _date_de_Naissance;
        public DateTimeOffset Date_de_Naissance
        {
            get
            {
                return _date_de_Naissance;
            }
            set
            {
                _date_de_Naissance = value;
                RaisePropertyChanged("Date_de_Naissance");
            }
        }
        private string _adr_Numero_de_rue;
        public string Adr_Numero_de_rue
        {
            get
            {
                return _adr_Numero_de_rue;
            }
            set
            {
                _adr_Numero_de_rue = value;
                RaisePropertyChanged("Adr_Numero_de_rue");
            }
        }
        private string _adr_Nom_de_Rue;
        public string Adr_Nom_de_Rue
        {
            get
            {
                return _adr_Nom_de_Rue;
            }
            set
            {
                _adr_Nom_de_Rue = value;
                RaisePropertyChanged("Adr_Nom_de_Rue");
            }
        }
        private int _adr_Code_Postal;
        public int Adr_Code_Postal
        {
            get
            {
                return _adr_Code_Postal;
            }
            set
            {
                _adr_Code_Postal = value;
                RaisePropertyChanged("Adr_Code_Postal");
            }
        }
        private string _adr_Localite;
        public string Adr_Localite
        {
            get
            {
                return _adr_Localite;
            }
            set
            {
                _adr_Localite = value;
                RaisePropertyChanged("Adr_Localite");
            }
        }
        private string _numero_de_Telephone;
        public string Numero_de_Telephone
        {
            get
            {
                return _numero_de_Telephone;
            }
            set
            {
                _numero_de_Telephone = value;
                RaisePropertyChanged("Numero_de_Telephone");
            }

        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged("Password");
            }
        }
       /* public ICommand GoToModification
        {
            get
            {
                if (_goToModification == null)
                    _goToModification = new RelayCommand(() => Modification());
                return _goToModification;
            }

        }

        private void Modification()
        {
            if ((Nom != null) && (Prenom != null) && (Date_de_Naissance != null) && (Adr_Numero_de_rue != null) && (Adr_Nom_de_Rue != null) && (Adr_Code_Postal != 0) && (Adr_Localite != null) && (Numero_de_Telephone != null))
            {
                ModificationUser util = new ModificationUser(Adresse_mail, Nom, Prenom, Date_de_Naissance.DateTime, Adr_Numero_de_rue, Adr_Nom_de_Rue, Adr_Code_Postal, Adr_Localite, Numero_de_Telephone);
                utilisateurMessage(util);
            }
            _navigationService.NavigateTo("CompteView");
        }
        private async Task utilisateurMessage(ModificationUser util)
        {
            var service = new UtilisateurService();
            var x = service.SetUtilisateur(util);
            
        }*/
    } 
}

