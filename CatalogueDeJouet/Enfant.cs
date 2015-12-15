using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueDeJouet
{
    class Enfant
    {
        private int id;
        private string prenom;
        private int idPapa;

        public Enfant(int pid, string pPrenom, int pidPapa)
        {
            id = pid;
            prenom = pPrenom;
            idPapa = pidPapa;
        }
        public string getPrenom()
        {
            return prenom;
        }
    }
}
