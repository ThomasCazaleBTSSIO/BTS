using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Technicien leTechnicien = new Technicien(matriculeTextBox1.Text, nomTextBox2.Text, prenomTextBox3.Text, formationTextBox4.Text, interventionTextBox6.Text, competenceTextBox7.Text);
            // Instanciation pour intéragir avec la base de données
            BD.ajouterTechnicien(leTechnicien);
        }

        List<Visiteur> lesVisiteurs;
        List<Technicien> lesTechniciens;
        BindingSource bindingSource;

        private void button3_Click(object sender, EventArgs e)
        {
            string matriculeVisiteur = textBoxSupprT.Text;
            BD.supprimerVisiteur(matriculeVisiteur);
        }

        private void textBoxSupprT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                BD.modifNom(ComboBoxMatricule.Text, textBox14.Text);
            }

            if (checkBox9.Checked)
            {
                BD.modifPrenom(ComboBoxMatricule.Text, textBox13.Text);
            }
            if (checkBox8.Checked)
            {
                BD.modifFormation(ComboBoxMatricule.Text, textBox12.Text);
            }
            if (checkBox7.Checked)
            {
                BD.modifIntervention(ComboBoxMatricule.Text, textBox11.Text);
            }
            if (checkBox1.Checked)
            {
                BD.modifCompetence(ComboBoxMatricule.Text, textBox10.Text);
            }

            MessageBox.Show("Modification effectué");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string matriculeTechnicien = textBoxSuppr.Text;
            BD.supprimerTechnicien(matriculeTechnicien);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Instanciation pour intéragir avec la base de données
            Visiteur leVisiteur = new Visiteur(textBoxMatriculeV.Text, textBoxNomV.Text, textBoxPrenomV.Text, textBoxAdresseV.Text, dateEmbaucheDateTimePicker1.Text, objectifTextBox6.Text, float.Parse(primeTextBox7.Text), avantageTextBox8.Text, float.Parse(budgetTextBox9.Text));
            // Ajouter un visiteur
            BD.ajouterVisiteur(leVisiteur);
        }

        private void ConsulterT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectTechnicien();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                BD.modifAdresse(MatriculeComboBox.Text, textBox8.Text);
            }

            if (checkBox3.Checked)
            {
                BD.modifObjectif(MatriculeComboBox.Text, textBox20.Text);
            }
            if (checkBox4.Checked)
            {
                BD.modifAvantages(MatriculeComboBox.Text, textBox21.Text);
            }
            if (checkBox5.Checked)
            {
                BD.modifPrimes(MatriculeComboBox.Text, textBox22.Text);
            }
            if (checkBox6.Checked)
            {
                BD.modifBudget(MatriculeComboBox.Text, textBox23.Text);
            }

            MessageBox.Show("Modification effectué");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string matriculeVisiteur = textBoxSupprV.Text;
            BD.supprimerVisiteur(matriculeVisiteur);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ComboBoxMatricule.Items.Clear();
            lesTechniciens = BD.selectTechnicien();

            foreach (Technicien leTechnicien in lesTechniciens)
            {
                ComboBoxMatricule.Items.Add(leTechnicien.MatriculeT);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MatriculeComboBox.Items.Clear();
            lesVisiteurs = BD.selectVisiteur();

            foreach (Visiteur leVisiteur in lesVisiteurs)
            {
                MatriculeComboBox.Items.Add(leVisiteur.MatriculeV);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
        }
    }
}
