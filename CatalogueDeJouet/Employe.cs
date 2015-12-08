﻿using System;
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

        public Employe(int pid, string pNom, string pPrenom, string pLogin, string pMdp, bool pAdmin)
        {
            id = pid;
            nom = pNom;
            prenom = pPrenom;
            login = pLogin;
            mdp = pMdp;
            admin = pAdmin;
        }
        public void setNom(string pNom)
        {
            nom = pNom;
        }
        public string getNom()
        {
            return nom;
        }
        public void setPrenom(string pPrenom)
        {
            prenom = pPrenom;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public void setLogin(string pLogin)
        {
            login = pLogin;
        }
        public string getLogin()
        {
            return login;
        }
        public void setMdp(string pMdp)
        {
            mdp = pMdp;
        }
        public string getMdp()
        {
            return mdp;
        }
    }
}
