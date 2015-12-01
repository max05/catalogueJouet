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
    class JouetDAO : DAO<CatalogueJouetPoulmane.Jouet>
    {
       override public ArrayList findAll()
        {
            ArrayList jouets = new ArrayList();

            SqlDataReader resultat = this.connexion("SELECT * FROM jouet ORDER BY id");
            while (resultat.Read())
            {
                for (int i = 0; i < resultat.FieldCount; i++)
                {

                    //lRes.Text += resultat.GetSqlValue(i).ToString().Trim() + "<br />";
                }
            }

            CatalogueJouetPoulmane.Categorie categ = new Categorie(1, "test");
            CatalogueJouetPoulmane.TrancheAge tranche = new TrancheAge(1, 5, 8);
            CatalogueJouetPoulmane.Jouet jouet = new CatalogueJouetPoulmane.Jouet(1, "bull", categ, tranche);
            jouets.Add(jouet);

            return jouets;
        }


        //CRUD
    }
}
