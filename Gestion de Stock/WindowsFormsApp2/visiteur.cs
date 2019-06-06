using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Visiteur
    {
        // Attribut privé
        private String matriculeV;
        private String nomV;
        private String prenomV;
        private String adresseV;
        private String dateV;
        private String objectifV;
        private double primeV;
        private String avantageV;
        private double budgetV;

    // Get / Set 
    public string MatriculeV { get => matriculeV; set => matriculeV = value; }
    public string NomV { get => nomV; set => nomV = value; }
    public string PrenomV { get => prenomV; set => prenomV = value; }
    public string AdresseV { get => adresseV; set => adresseV = value; }
    public String DateV { get => dateV; set => dateV = value; }
    public string ObjectifV { get => objectifV; set => objectifV = value; }
    public double PrimeV { get => primeV; set => primeV = value; }
    public string AvantageV { get => avantageV; set => avantageV = value; }
    public double BudgetV { get => budgetV; set => budgetV = value; }
    
     // Constructeur 
    public Visiteur(String unMatriculeV, String unNomV, String unPrenomV, String uneAdresseV, String uneDateV, String unObjectifV, double unePrimeV, String unAvantageV, double unBudgetV)
    {
        matriculeV = unMatriculeV;
        nomV = unNomV;
        prenomV = unPrenomV;
        adresseV = uneAdresseV;
        dateV = uneDateV;
        objectifV = unObjectifV;
        primeV = unePrimeV;
        avantageV = unAvantageV;
        budgetV = unBudgetV;
    }

}
}