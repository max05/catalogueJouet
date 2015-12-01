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
    abstract class DAO<T>
    {
        static SqlConnection Connection;
         public SqlDataReader connexion(string pRequete)
        {
            SqlDataReader reader;
            Connection = new SqlConnection("Database=hopitalPPEPoulmaneWanDebruyckere;Data Source=win-921c8fktgae;User Id=debruyckere;Password=debruyckere");


            Connection.Open();                      // ouverture de la connection
            SqlCommand MyCommand = new SqlCommand(pRequete, Connection);
            reader = MyCommand.ExecuteReader();
            // fermeture de la connection

            return reader;
        }
         public void closeConnection()
         {
             Connection.Close();
         }
        /*public abstract Boolean create(T unObjet);
        
        public abstract T find(int id);

        public abstract Boolean update(T unObjet);

        public abstract Boolean delete(T unObjet);*/

        public abstract ArrayList findAll();
    }
}
