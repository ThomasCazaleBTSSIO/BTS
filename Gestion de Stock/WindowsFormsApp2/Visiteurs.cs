using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciation pour intéragir avec la base de données
            Visiteur leVisiteur = new Visiteur(matriculeTextBox1.Text, nomTextBox2.Text, prenomTextBox3.Text, adresseTextBox4.Text, dateEmbaucheDateTimePicker1.Text, objectifTextBox6.Text, float.Parse(primeTextBox7.Text), avantageTextBox8.Text, float.Parse(budgetTextBox9.Text));
            // Ajouter un visiteur
            BD.ajouterVisiteur(leVisiteur);          
        }
        List<Visiteur> lesVisiteurs;
        BindingSource bindingSource;

        private void Form3_Load_1(object sender, EventArgs e)
        {
            lesVisiteurs = new List<Visiteur>();
            bindingSource = new BindingSource();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string matriculeVisiteur = textBoxSupprV.Text;
            BD.supprimerVisiteur(matriculeVisiteur);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                BD.modifAdresse(MatriculeComboBox.Text, textBox2.Text);
            }

            if (checkBox3.Checked)
            {
                BD.modifObjectif(MatriculeComboBox.Text, textBox6.Text);
            }
            if (checkBox4.Checked)
            {
                BD.modifAvantages(MatriculeComboBox.Text, textBox5.Text);
            }
            if (checkBox5.Checked)
            {
                BD.modifPrimes(MatriculeComboBox.Text, textBox4.Text);
            }
            if (checkBox6.Checked)
            {
                BD.modifBudget(MatriculeComboBox.Text, textBox3.Text);
            }

            MessageBox.Show("Modification effectué");
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
    }

}


