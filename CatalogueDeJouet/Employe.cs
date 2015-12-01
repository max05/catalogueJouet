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

        public Employe(int pid, string pNom, string pPrenom, string pLogin, string pMdp, bool pAdmin)
        {
            id = pid;
            nom = pNom;
            prenom = pPrenom;
            login = pLogin;
            mdp = pMdp;
            admin = pAdmin;
        }
    }
}
