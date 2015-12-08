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
    /*class EmployeDAO : DAO<Employe>
    {
        //CRUD
        public override System.Collections.ArrayList findAll(string pUserName, string pPassword)
        {
            throw new NotImplementedException();
            bool valide = false;

            SqlDataReader resultat = connexion("Select login,mdp From Login");
            while (resultat.Read())
            {
                for (int i = 0; i < resultat.FieldCount; i++)
                {
                    username = (i, ((string)resultat["login"]));
                    password = (i,((string)resultat["mdp"]));
     
                    if (username == pUserName && password == pPassword)
                        {
                            valide = true;
                        }
                }
            }
            
            
            Connection.Close();
            return valide;
        } 
     }*/
}
