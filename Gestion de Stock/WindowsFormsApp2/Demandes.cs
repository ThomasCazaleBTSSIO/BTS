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
    public partial class Demandes : Form
    {
        public Demandes()
        {
            InitializeComponent();
        }
        List<demande> lesDemandes;
        BindingSource bindingSource;

        private void Demandes_Load_1(object sender, EventArgs e)
        {
            lesDemandes = new List<demande>();
            bindingSource = new BindingSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            demande uneDemande = new demande(int.Parse(textBoxTicket.Text), textBoxMateriel.Text, textBoxObjet.Text, int.Parse(textBoxUrgence.Text), dateTimePicker1.Value);
            // Instanciation pour intéragir avec la base de données
            BD.ajouterDemande(uneDemande);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectDemande();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectDemande();
        }
    }
}
