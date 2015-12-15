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
    class EnfantDAO : DAO<Enfant>
    {
        Enfant unEnfant;
        public override System.Collections.ArrayList findAll()
        {
            throw new NotImplementedException();

        }
        public ArrayList findEnfants(int id)            //Trouve les enfants d'un employer
        {
            ArrayList enfants = new ArrayList();
            SqlDataReader resultat = connexion("Select idEnfant,prenom From Enfant where idEmploye='" + id + "'");
            while (resultat.Read())
            {
                int idEnfant=(int)resultat["idEnfant"];
                string prenom = (string)resultat["prenom"];
                unEnfant=new Enfant(idEnfant,prenom,id);
            }
            this.closeConnection();
            return enfants;
        }
        public override Enfant find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
