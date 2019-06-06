using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class personnel
    {
        private string matricule { get; }
        private string nom { get; }
        private string prenom { get; }
        private DateTime date { get; }

        public personnel (string unMatricule, string unNom, string unPrenom, DateTime uneDate)
        {
            matricule = unMatricule;
            nom = unNom;
            prenom = unPrenom;
            date = uneDate; 
        }
        
    }
}
