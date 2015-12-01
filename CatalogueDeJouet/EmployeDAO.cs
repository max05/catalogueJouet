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
                    //lRes.Text += resultat.GetSqlValue(i).ToString().Trim() + "<br />";
                }
            }
            string username = "a";
            string password = "a";
            if (username == pUserName && password == pPassword)
            {
                valide = true;
            }
            Connection.Close();
            return valide;
        } 
     }*/
}
