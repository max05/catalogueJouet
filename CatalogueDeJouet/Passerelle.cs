﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CatalogueJouetPoulmane;
using System.Data.SqlClient;

namespace CatalogueDeJouet
{
    
    class Passerelle
    {
        static SqlConnection Connection;
        /// <summary>
        /// Fais la connexion
        /// </summary>
        /// <param name="pUserName">Nom d'utilisateur.</param>
        /// <param name="pPassword">Mot de passe.</param>
        /// <returns></returns>
        static public bool identification(string pUserName, string pPassword)
        {
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
        static public SqlConnection connexionSeul()
        {
            Connection = new SqlConnection("Database=hopitalPPEPoulmaneWanDebruyckere;Data Source=win-921c8fktgae;User Id=debruyckere;Password=debruyckere");
            Connection.Open();                      // ouverture de la connection
            return Connection; ;
            
        }

        static public SqlDataReader connexion(string pRequete)
        {
            SqlDataReader reader;
             Connection = new SqlConnection("Database=hopitalPPEPoulmaneWanDebruyckere;Data Source=win-921c8fktgae;User Id=debruyckere;Password=debruyckere");
            
                
                Connection.Open();                      // ouverture de la connection
                SqlCommand MyCommand = new SqlCommand(pRequete, Connection);
                reader = MyCommand.ExecuteReader();
                                   // fermeture de la connection
            
            return reader;  
        }
        static public ArrayList lesJouets()
        {
            ArrayList jouets=new ArrayList();

            /* [type]JouetsBDD=connexion("SELECT * FROM jouet ORDER BY id") */
            CatalogueJouetPoulmane.Categorie categ= new Categorie(1,"test");
            CatalogueJouetPoulmane.TrancheAge tranche= new TrancheAge(1,5,8);
            CatalogueJouetPoulmane.Jouet jouet = new CatalogueJouetPoulmane.Jouet(1,"bull",categ,tranche);
            jouets.Add(jouet);
            Connection.Close();  
            return jouets;
        }

    }
}
