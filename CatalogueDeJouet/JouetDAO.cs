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
        /// <summary>
        /// Recupère tout les jouets présent dans la base de données
        /// </summary>
        /// <returns></returns>
        public override ArrayList findAll()
        {
            ArrayList jouets = new ArrayList();
            CatalogueJouetPoulmane.Categorie laCategorie;
            CatalogueJouetPoulmane.TrancheAge laTranche;
            CatalogueJouetPoulmane.Jouet unJouet;
            int i = 0;
            SqlDataReader resultat = this.connexion("SELECT c.libelle as catLib,j.libelle as jouetLib,t.ageMin as ageMin,t.ageMax as ageMax FROM jouet j join Categorie c on c.idCategorie=j.idCategorie join TrancheAge t on j.idTrancheAge=t.idTrancheAge ORDER BY j.libelle");
            while (resultat.Read())
            {
                    laCategorie = new Categorie(i, ((string)resultat["catLib"]));
                    laTranche = new TrancheAge(i,((int)resultat["ageMin"]),((int)resultat["ageMax"]));
                    unJouet = new Jouet(i, ((string)resultat["jouetLib"]), laCategorie, laTranche);
                    jouets.Add(unJouet);
                    i++;
            }
            this.closeConnection();
            return jouets;
        }
        public override Jouet find()
        {
            throw new NotImplementedException();
        }

        //CRUD
    }
}
