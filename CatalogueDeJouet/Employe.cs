using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueDeJouet
{
    class Employe
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string mdp;
        private bool admin;

        public Employe(int pid,string pNom, string pPrenom)
        {
            id = pid;
            nom = pNom;
            prenom = pPrenom;
        }
        /*public Employe(int pid, string pLogin, string pMdp)
        {
            id = pid;
            login = pLogin;
            mdp = pMdp;
        }*/
        public string getLogin()
        {
            return login;
        }
        public string getMdp()
        {
            return mdp;
        }
        public string getNom()
        {
            return nom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public void setNom(string pNom)
        {
            nom = pNom;
        }
        public void setPrenom(string pPrenom)
        {
            prenom = pPrenom;
        }
        
        public void setLogin(string pLogin)
        {
            login = pLogin;
        }
        public void setMdp(string pMdp)
        {
            mdp = pMdp;
        }
    }
}
