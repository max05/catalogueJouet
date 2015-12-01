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
        static public SqlDataReader connexion(string pRequete)
        {
            SqlDataReader reader;
            SqlConnection Connection = new SqlConnection("Database=win-921c8fktgae.hopitalPPEPoulmaneWanDebruyckere;Data Source=localhost;User Id=debruyckere;Password=debruyckere");


            Connection.Open();                      // ouverture de la connection
            SqlCommand MyCommand = new SqlCommand(pRequete, Connection);
            reader = MyCommand.ExecuteReader();
            Connection.Close();                     // fermeture de la connection

            return reader;
        }
        public abstract Boolean create(T unObjet);
        
        public abstract T find(int id);

        public abstract Boolean update(T unObjet);

        public abstract Boolean delete(T unObjet);
    }
}
