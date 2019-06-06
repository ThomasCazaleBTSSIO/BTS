using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class BD
    {
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private System.Data.DataSet ds = new System.Data.DataSet();

        public static void ajouterVisiteur(Visiteur unVisiteur)
        {
            //Connexion

            try
            {
                String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO visiteur(matriculev, nomv, prenomv, adressev, datev, objectifv, primev, avantagev, budgetv) VALUES(@matriculev, @nomv, @prenomv, @adressev, @datev, @objectifv, @primev, @avantagev, @budgetv)";
                cmd.Parameters.AddWithValue("@matriculev", unVisiteur.MatriculeV);
                cmd.Parameters.AddWithValue("@nomv", unVisiteur.NomV);
                cmd.Parameters.AddWithValue("@prenomv", unVisiteur.PrenomV);
                cmd.Parameters.AddWithValue("@adressev", unVisiteur.AdresseV);
                cmd.Parameters.AddWithValue("@datev", unVisiteur.DateV);
                cmd.Parameters.AddWithValue("@objectifv", unVisiteur.ObjectifV);
                cmd.Parameters.AddWithValue("@primev", Convert.ToDouble(unVisiteur.PrimeV));
                cmd.Parameters.AddWithValue("@avantagev", unVisiteur.AvantageV);
                cmd.Parameters.AddWithValue("@budgetv", Convert.ToDouble(unVisiteur.BudgetV));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistré dans la base !", "Réussite", MessageBoxButtons.OK);
                conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public static List<Visiteur> selectVisiteur()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT matriculev, nomv, prenomv, adressev, datev, objectifv, primev, avantagev, budgetv FROM visiteur";
            MySqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Visiteur unVisiteur = new Visiteur(Convert.ToString(datareader["matriculev"]), Convert.ToString(datareader["nomv"]), Convert.ToString(datareader["prenomv"]), Convert.ToString(datareader["adressev"]), Convert.ToString(datareader["datev"]), Convert.ToString(datareader["objectifv"]), Convert.ToDouble(datareader["primev"]), Convert.ToString(datareader["avantagev"]), Convert.ToDouble(datareader["budgetv"]));
                lesVisiteurs.Add(unVisiteur);
            }
            return lesVisiteurs;
        }


        public static void supprimerVisiteur(string supprimVisiteur)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM visiteur WHERE matriculev ='" + supprimVisiteur + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé de la base !", "Réussite", MessageBoxButtons.OK);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void modifAdresse(string matriculeValue, string AdresseValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE visiteur set adressev = '" + AdresseValue + "' where matriculev = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifObjectif(string matriculeValue, string ObjectifValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE visiteur set  objectifv = '" + ObjectifValue + "' where matriculev = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifAvantages(string matriculeValue, string AvantagesValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE visiteur set  avantagev= '" + AvantagesValue + "' where matriculev = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifPrimes(string matriculeValue, string PrimesValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE visiteur set primev = '" + PrimesValue + "' where matriculev = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifBudget(string matriculeValue, string BudgetValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE visiteur set budgetv = '" + BudgetValue + "' where matriculev = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void ajouterTechnicien(Technicien unTechnicien)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO technicien(matriculet, nomt, prenomt, formationt, nivInterventiont, competencet) VALUES(@matriculet, @nomt, @prenomt, @formationt, @nivInterventiont, @competencet)";
                cmd.Parameters.AddWithValue("@matriculet", unTechnicien.MatriculeT);
                cmd.Parameters.AddWithValue("@nomt", unTechnicien.NomT);
                cmd.Parameters.AddWithValue("@prenomt", unTechnicien.PrenomT);
                cmd.Parameters.AddWithValue("@formationt", unTechnicien.FormationT);
                cmd.Parameters.AddWithValue("@nivInterventiont", unTechnicien.NivInterventionT);
                cmd.Parameters.AddWithValue("@competencet", unTechnicien.CompetenceT);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistré dans la base !", "Réussite", MessageBoxButtons.OK);

            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Technicien> selectTechnicien()
        {
            List<Technicien> lesTechniciens = new List<Technicien>();
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT matriculet, nomt, prenomt, formationt, nivInterventiont, competencet FROM technicien";
            MySqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Technicien unTechnicien = new Technicien(Convert.ToString(datareader["matriculet"]), Convert.ToString(datareader["nomt"]), Convert.ToString(datareader["prenomt"]), Convert.ToString(datareader["formationt"]), Convert.ToString(datareader["nivInterventiont"]), Convert.ToString(datareader["competencet"]));
                lesTechniciens.Add(unTechnicien);
            }
            return lesTechniciens;
        }

        public static void modifNom(string matriculeValue, string NomValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set nomt = '" + NomValue + "' where matriculet = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifPrenom(string matriculeValue, string PrenomValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set prenomt = '" + PrenomValue + "' where matriculet = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifFormation(string matriculeValue, string FormationValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set formationt = '" + FormationValue + "' where matriculet = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifIntervention(string matriculeValue, string InterventionValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set nivInterventiont = '" + InterventionValue + "' where matriculet = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void modifCompetence(string matriculeValue, string CompetenceValue)
        {
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set competencet = '" + CompetenceValue + "' where matriculet = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void supprimerTechnicien(string supprimTEchnicien)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM technicien WHERE matriculet ='" + supprimTEchnicien + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé de la base !", "Réussite", MessageBoxButtons.OK);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ajouterDemande(demande uneDemande)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO demande(ticket, materield, objetd, urgenced, etatd, dated) VALUES(@ticket, @materield, @objetd, @urgenced, 'déclaré', @dated)";
                cmd.Parameters.AddWithValue("@ticket", uneDemande.Ticket);
                cmd.Parameters.AddWithValue("@materield", uneDemande.Materield);
                cmd.Parameters.AddWithValue("@objetd", uneDemande.Objetd);
                cmd.Parameters.AddWithValue("@urgenced", Convert.ToDouble(uneDemande.Urgenced));
                cmd.Parameters.AddWithValue("@dated", Convert.ToDateTime(uneDemande.Dated));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistré dans la base !", "Réussite", MessageBoxButtons.OK);

            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<demande> selectDemande()
        {
            List<demande> lesDemandes = new List<demande>();
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ticket, materield, objetd, urgenced, etatd, technicien, dated, travail FROM demande";
            MySqlDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                demande uneDemande = new demande(Convert.ToInt32(datareader["ticket"]), Convert.ToString(datareader["materield"]), Convert.ToString(datareader["objetd"]), Convert.ToInt32(datareader["urgenced"]), Convert.ToDateTime(datareader["dated"]));
                lesDemandes.Add(uneDemande);
            }
            conn.Close();
            return lesDemandes;
        }


        public static void supprimerDemande(string supprimDemande)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM demande WHERE ticket ='" + supprimDemande + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé de la base !", "Réussite", MessageBoxButtons.OK);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AffecterUnTech(int matriculet, int ticket)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; password = Az123@;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE demande set technicien = @matriculet, etatd = 'Affecter' WHERE ticket = @ticket";
            cmd.Parameters.AddWithValue("@matriculet", matriculet);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            cmd.ExecuteNonQuery();
            MessageBox.Show("La demande a bien été affecter au technicien !");
            conn.Close();
        }

        public static void FinTravail(string FinTravail, int ticket)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; password = Az123@; SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE demande set travail = @finTravail, etatd = 'Travail terminé' WHERE ticket = @ticket";
            cmd.Parameters.AddWithValue("@finTravail", FinTravail);
            cmd.Parameters.AddWithValue("@ticket", ticket);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Le travail sur la demande à bien été effctuer !");
            conn.Close();
        }

        public static void ajouterMateriel(materiel unMateriel)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO materiel(idM, processeur, disque, memoire, garantie, ticket) VALUES(@idM, @processeur, @disque, @memoire, @garantie, @ticket)";
                cmd.Parameters.AddWithValue("@idM", unMateriel.IdM);
                cmd.Parameters.AddWithValue("@processeur", unMateriel.Processeur);
                cmd.Parameters.AddWithValue("@disque", unMateriel.Disque);
                cmd.Parameters.AddWithValue("@memoire", unMateriel.Memoire);
                cmd.Parameters.AddWithValue("@garantie", unMateriel.Garantie);
                cmd.Parameters.AddWithValue("@ticket", unMateriel.Ticket);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Enregistré dans la base !", "Réussite", MessageBoxButtons.OK);

            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<materiel> selectMateriel()
        {
            List<materiel> LesMateriels = new List<materiel>();

            string connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; password = Az123@; SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT idM, processeur, disque, memoire, garantie, ticket FROM materiel";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                materiel unMateriel = new materiel(Convert.ToString(dataReader["idM"]), Convert.ToString(dataReader["processeur"]), Convert.ToString(dataReader["disque"]), Convert.ToString(dataReader["memoire"]), Convert.ToString(dataReader["garantie"]), Convert.ToInt16(dataReader["ticket"]));
                LesMateriels.Add(unMateriel);
            }

            conn.Close();
            return LesMateriels;
        }

        public static void supprimerMateriel(string supprimMateriel)
        {
            //Connexion
            String connString = "Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            try
            {
                // Requete SQL 
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM materiel WHERE idm ='" + supprimMateriel + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supprimé de la base !", "Réussite", MessageBoxButtons.OK);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }

}

