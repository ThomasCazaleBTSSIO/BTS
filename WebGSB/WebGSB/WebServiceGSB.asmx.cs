using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WebGSB
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceGSB : System.Web.Services.WebService
    {
        /// <summary>
        /// Permet d'instancier une connexion à la BD.
        /// </summary>
        /// <returns>une connexion MySql</returns>
        public MySqlConnection ConnexionBD() { return new MySqlConnection(ConfigurationManager.ConnectionStrings["gsb_medic"].ConnectionString); }

        /// <summary>
        /// Permet d'obtenir les effets indésirables d'un médicament.
        /// </summary>
        /// <param name="id">identifiant du médicament</param>
        /// <returns>un tableau de chaînes de caractères</returns>
        [WebMethod]
        public string[] GetMedicaments()
        {
            MySqlConnection conn = ConnexionBD();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            // nombre de résultats
            cmd.CommandText = @"
            SELECT COUNT(*)
            FROM medicaments";

            string[] medicaments = new string[Convert.ToInt32(cmd.ExecuteScalar())]; // création du tableau

            // requête de sélection
            cmd.CommandText = @"
            SELECT idMedicament, libelleMedicament, libelleFamille
            FROM medicaments
            JOIN famille ON familleMedicament = idFamille";

            // lecture des résultats
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;

                while (reader.Read())
                {
                    medicaments[i] = reader["idMedicament"].ToString() + "|" + reader["libelleMedicament"].ToString() + "|" + reader["libelleFamille"].ToString();
                    i++;
                }
            }

            conn.Close();
            return medicaments;
        }

        /// <summary>
        /// Permet d'obtenir les effets indésirables d'un médicament.
        /// </summary>
        /// <param name="id">identifiant du médicament</param>
        /// <returns>un tableau de chaînes de caractères</returns>
        [WebMethod]
        public string[] GetEffets(string id)
        {
            MySqlConnection conn = ConnexionBD();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@medicaments", id);

            // nombre de résultats
            cmd.CommandText = @"
            SELECT COUNT(*)
            FROM avoir
            WHERE aIdMedicament = @medicaments";

            string[] effets = new string[Convert.ToInt32(cmd.ExecuteScalar())]; // création du tableau

            // requête de sélection
            cmd.CommandText = @"
            SELECT libelleEffetT, descriptionEffetT
            FROM effettherapeutique
            JOIN avoir ON idEffetT = aIdEffet
            WHERE aIdMedicament = @medicaments";

            // lecture des résultats
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;

                while (reader.Read())
                {
                    effets[i] = reader["libelleEffetT"].ToString() + "|" + reader["descriptionEffetT"].ToString();
                    i++;
                }
            }

            conn.Close();
            return effets;
        }

        /// <summary>
        /// Permet d'obtenir les contre-indications d'un médicament.
        /// </summary>
        /// <param name="id">identifiant du médicament</param>
        /// <returns>un tableau de chaînes de caractères</returns>
        [WebMethod]
        public string[] GetContreIndications(string id)
        {
            MySqlConnection conn = ConnexionBD();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@medicaments", id);

            // nombre de résultats
            cmd.CommandText = @"
            SELECT COUNT(*)
            FROM posseder
            WHERE pIdMedicament = @medicaments";

            string[] contreIndications = new string[Convert.ToInt32(cmd.ExecuteScalar())]; // création du tableau

            // requête de sélection
            cmd.CommandText = @"
            SELECT libelleContreIndication, descriptionContreIndication
            FROM contreindications
            JOIN posseder ON idContreIndication = pIdContreIndication
            WHERE pIdMedicament = @medicaments";

            // lecture des résultats
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;

                while (reader.Read())
                {
                    contreIndications[i] = reader["libelleContreIndication"].ToString() + "|" + reader["descriptionContreIndication"].ToString();
                    i++;
                }
            }

            conn.Close();
            return contreIndications;
        }
    }
}


