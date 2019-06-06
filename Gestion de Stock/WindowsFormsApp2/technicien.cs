using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Technicien
    {
        //Attribut privé
        private String matriculeT;
        private String nomT;
        private String prenomT;
        private String formationT;
        private String nivInterventionT;
        private String competenceT;

        // Get / Set 
        public string MatriculeT { get => matriculeT; set => matriculeT = value; }
        public string NomT { get => nomT; set => nomT = value; }
        public string PrenomT { get => prenomT; set => prenomT = value; }
        public string FormationT { get => formationT; set => formationT = value; }
        public string NivInterventionT { get => nivInterventionT; set => nivInterventionT = value; }
        public string CompetenceT { get => competenceT; set => competenceT = value; }


        // Constructeur 
        public Technicien(String unMatriculeT, String unNomT, String unPrenomT, String uneFormationT, String unNivInterventionT, String uneCompetenceT)
        {
            matriculeT = unMatriculeT;
            nomT = unNomT;
            prenomT = unPrenomT;
            formationT = uneFormationT;
            nivInterventionT = unNivInterventionT;
            competenceT = uneCompetenceT;

        }
    }
}