using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class fournisseur
    {
        private string idf { get; }
        private string nomf { get; }

        public fournisseur (string unId, string unNom)
        {
            idf = unId;
            nomf = unNom; 
        }
    }
}
