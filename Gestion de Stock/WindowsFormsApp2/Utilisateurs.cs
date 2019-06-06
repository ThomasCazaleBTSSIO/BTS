using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Utilisateurs : Form
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }

        // Afficher un message d'alerte lors de la fermeture de la fenêtre principale
        private void Utilisateurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Fermeture", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBoxMdp.UseSystemPasswordChar = false;
            else
                textBoxMdp.UseSystemPasswordChar = true; 
        }

        private void buttonSeCo_Click(object sender, EventArgs e)
        {
            //Ajoute ou actualise les lignes de DataTable pour établir une correspondance avec celles de la source de données à l'aide du nom DataTable
           
            MySqlConnection conn = new MySqlConnection("Server = 127.0.0.1; Database = gsb_medic; Uid = dev; Password = Az123@; SslMode = none;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM utilisateurs WHERE idUtilisateur ='" + textBoxId.Text + "' AND mdpUtilisateur = '" + textBoxMdp.Text + "'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // Liaison entre la commande et la DataAdapter
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i]["Type"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("Vous êtes connecté en tant que " + dt.Rows[i][2]);
                        if(comboBox1.SelectedIndex == 0) 
                        {
                            Demandes f = new Demandes();
                            f.Show();
                            this.Hide();
                        }
                        else if(comboBox1.SelectedIndex == 1)
                        {
                            Form1 ff = new Form1();
                            ff.Show();
                            this.Hide();
                        }
                        else if(comboBox1.SelectedIndex == 2)
                        {
                            Form4 fff = new Form4();
                            fff.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Login ou Mot de passe incorrect");
            }
        }
    }
}
