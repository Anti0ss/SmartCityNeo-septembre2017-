using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSmartCity.Models
{
    public class ModificationUser
    {
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date_de_Naissance { get; set; }
        public string Adr_Numero_de_rue { get; set; }
        public string Adr_Nom_de_Rue { get; set; }
        public int Adr_Code_Postal { get; set; }
        public string Adr_Localite { get; set; }
        public string Numero_de_Telephone { get; set; }
        public ModificationUser(string email, string nom, string prenom, DateTime date_de_Naissance, string adr_Numero_de_rue, string adr_Nom_de_Rue, int adr_Code_Postal, string adr_Localite, string numero_de_Telephone)
        {
            this.Email = email;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Date_de_Naissance = date_de_Naissance;
            this.Adr_Numero_de_rue = adr_Numero_de_rue;
            this.Adr_Nom_de_Rue = adr_Nom_de_Rue;
            this.Adr_Code_Postal = adr_Code_Postal;
            this.Adr_Localite = adr_Localite;
            this.Numero_de_Telephone = numero_de_Telephone;
        }
    }
}
