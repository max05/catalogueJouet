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
        static public ArrayList lesJouets()
        {
            ArrayList jouets = new ArrayList();

            CatalogueJouetPoulmane.Jouet JouetsBDD = this.connexion("SELECT * FROM jouet ORDER BY id");
            CatalogueJouetPoulmane.Categorie categ = new Categorie(1, "test");
            CatalogueJouetPoulmane.TrancheAge tranche = new TrancheAge(1, 5, 8);
            CatalogueJouetPoulmane.Jouet jouet = new CatalogueJouetPoulmane.Jouet(1, "bull", categ, tranche);
            jouets.Add(jouet);

            return jouets;
        }
        //CRUD
    }
}
