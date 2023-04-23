using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corona
{
    public class Citoyen
    {
        public string Cin;
        public string NomEtPrenom;
        public string DateDeNaissance;
        public int NumeroDeTelephone;
        public string CodeCouleur;
        public string Adresse;
        public Boolean Vaccin = false;
        public Boolean Frequente = false;
        public Boolean Encontact = false;
        public Boolean patient = false;
        public Boolean symptomatic = false;
        public Boolean gueris;
        public bool testcorona;
        public bool suspect;


        public Citoyen()
        {
        }
        public Citoyen(string cin)
        {
            this.Cin = cin;
        }
        public Citoyen(string cin, string NomEtPrenom, string DateDeNaissance, int NumeroDeTelephone, string Adresse)
        {
            this.Cin = cin;
            this.NomEtPrenom = NomEtPrenom;
            this.DateDeNaissance = DateDeNaissance;
            this.NumeroDeTelephone = NumeroDeTelephone;
            this.Adresse = Adresse;
        }
       public Citoyen(string Cin, string NomEtPrenom, string DateDeNaissance, int NumeroDeTelephone, string CodeCouleur, string Adresse, bool Vaccin, bool Frequente, bool EnContact, bool patient)
        {
            this.Cin = Cin;
            this.NomEtPrenom = NomEtPrenom;
            this.DateDeNaissance = DateDeNaissance;
            this.NumeroDeTelephone = NumeroDeTelephone;
            this.CodeCouleur = CodeCouleur;
            this.Adresse = Adresse;
            this.Vaccin = Vaccin;
            this.Frequente = Frequente;
            this.Encontact = EnContact;
            this.patient = patient;

        }
        public Citoyen(string Cin, string NomEtPrenom, string DateDeNaissance, int NumeroDeTelephone, string CodeCouleur, string Adresse, bool Vaccin, bool Frequente, bool EnContact, bool patient,bool testcorona)
        {
            this.Cin = Cin;
            this.NomEtPrenom = NomEtPrenom;
            this.DateDeNaissance = DateDeNaissance;
            this.NumeroDeTelephone = NumeroDeTelephone;
            this.CodeCouleur = CodeCouleur;
            this.Adresse = Adresse;
            this.Vaccin = Vaccin;
            this.Frequente = Frequente;
            this.Encontact = EnContact;
            this.patient = patient;
            this.testcorona = testcorona;

        }
        public Citoyen(string Cin, string NomEtPrenom, string DateDeNaissance, int NumeroDeTelephone, string CodeCouleur, string Adresse, bool Vaccin, bool Frequente, bool EnContact, bool patient, bool testcorona,bool symptomatic)
        {
            this.Cin = Cin;
            this.NomEtPrenom = NomEtPrenom;
            this.DateDeNaissance = DateDeNaissance;
            this.NumeroDeTelephone = NumeroDeTelephone;
            this.CodeCouleur = CodeCouleur;
            this.Adresse = Adresse;
            this.Vaccin = Vaccin;
            this.Frequente = Frequente;
            this.Encontact = EnContact;
            this.patient = patient;
            this.testcorona = testcorona;
            this.symptomatic = symptomatic;

        }
        public bool IsVaccinated()
        {
            return Vaccin;
        }

        public string GetColor()
        {
            return CodeCouleur;
        }

        public bool IsSuspect()
        {
            return (symptomatic || Frequente || Encontact);
        }

        public bool IsPatient()
        {
            return patient;
        }




    }
}
