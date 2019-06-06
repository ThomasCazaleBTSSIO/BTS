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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewM.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectMateriel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD.supprimerMateriel(textBoxSupprimerM.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewD.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectDemande();
        }

        List<demande> lesDemandes;
        List<materiel> LesMateriels;
        BindingSource bindingSource;
    
        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciation pour intéragir avec la base de données
            materiel unMateriel = new materiel(idTextBox1.Text, processeurTextBox2.Text, disqueTextBox3.Text, memoireTextBox4.Text, garantieTextBox5.Text, int.Parse(ticketTextBox6.Text));
            BD.ajouterMateriel(unMateriel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lesDemandes = new List<demande>();
            LesMateriels = new List<materiel>();
            bindingSource = new BindingSource();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAffecter_Click(object sender, EventArgs e)
        {
            BD.AffecterUnTech(Convert.ToInt16(textBoxAffecterTech.Text), Convert.ToInt16(textBoxTicket.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BD.FinTravail(textBoxTravailEff.Text, Convert.ToInt16(textBoxTicket.Text));
        }

        private void SupprimerDemande_Click(object sender, EventArgs e)
        {
            BD.supprimerDemande(textBoxTicket.Text);
        }
    }
}
