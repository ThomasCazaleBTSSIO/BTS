using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class demande
    {
        private int ticket;
        private string materield;
        private string objetd;
        private int urgenced;
        private string etatd;
        private string technicien;
        private DateTime dated;
        private string travail;

        public int Ticket { get => ticket; set => ticket = value; }
        public string Materield { get => materield; set => materield = value; }
        public string Objetd { get => objetd; set => objetd = value; }
        public int Urgenced { get => urgenced; set => urgenced = value; }
        public string Etatd { get => etatd; set => etatd = value; }
        public string Technicien { get => technicien; set => technicien = value; }
        public DateTime Dated { get => dated; set => dated = value; }
        public string Travail { get => travail; set => travail = value; }

        public demande(int unTicket, string unMateriel, string unObjet, int uneUrgence, DateTime uneDate)
        {
            Ticket = unTicket;
            Materield = unMateriel;
            Objetd = unObjet;
            Urgenced = uneUrgence;
            Dated = uneDate;
        }
    }
} 