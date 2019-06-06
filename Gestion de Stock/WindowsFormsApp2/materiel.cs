    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace WindowsFormsApp2 
    {
        class materiel
        {
            // Attribut privé
            private String idM;
            private String processeur;
            private String disque;
            private String memoire;
            private String garantie;
            private int ticket;

            // Get / Set 
            public string IdM { get => idM; set => idM = value; }
            public string Processeur { get => processeur; set => processeur = value; }
            public string Disque { get => disque; set => disque = value; }
            public string Memoire { get => memoire; set => memoire = value; }
            public string Garantie { get => garantie; set => garantie = value; }
            public int Ticket{ get => ticket; set => ticket = value; }

            // Constructeur 
            public materiel(String unIdM, String unProcesseur, String unDisque, String uneMemoire, String uneGarantie, int unTicket)
            {
                idM = unIdM;
                processeur = unProcesseur;
                disque = unDisque;
                memoire = uneMemoire;
                garantie = uneGarantie;
                ticket = unTicket;
            }
        }
    }