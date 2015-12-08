using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CatalogueJouetPoulmane;
using System.Data.SqlClient;

namespace CatalogueDeJouet
{
    class EmployeDAO : DAO<Employe>
    {
        Employe unEmploye ;
        string username;
        public  Employe findlogin(string pUserName, string pPassword)
        {
            Employe lEmploye=null;
            

            SqlDataReader resultat = connexion("Select login,mdp From Login");
            int i=0;
            while (resultat.Read())
            {
                 unEmploye= new Employe(i,((string)resultat["login"]),((string)resultat["mdp"]));
                    username = unEmploye.getLogin();
                    string password = unEmploye.getMdp();
     
                    if (username == pUserName && password == pPassword)
                        {
                            
                            lEmploye=findEmployer();
                        }
                i++;
            }
            
            
            this.closeConnection();
            return lEmploye;
        }
        public Employe findEmployer()
        {
            SqlDataReader resultat = connexion("Select nom,prenom From employe e join Login l on l.idEmploye=e.idEmploye where login='" + username + "'");

            string nom = (string)resultat["nom"];
            string prenom = (string)resultat["prenom"];
            unEmploye = new Employe(nom, prenom);
            this.closeConnection();
            return unEmploye;
        }
        public Employe getEmployer()
        {
            return unEmploye;
        }
        public override ArrayList findAll()
        {
            throw new NotImplementedException();
        }
        public override Employe find()
        {
            throw new NotImplementedException();
        }
     }
}
