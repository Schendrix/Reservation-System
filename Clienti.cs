using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    public partial class Clienti : Form
    {
        public static int id;
        public static string nume;
        public static string prenume;
        public static string email;
        public static string telefon;
        public Clienti(int id, string nume, string prenume, string email, string telefon)
        {
            InitializeComponent();
            Clienti.id = id;
            Clienti.nume = nume;
            Clienti.prenume = prenume;
            Clienti.email = email;
            Clienti.telefon = telefon;
            
        }
        public Clienti()
        {

            InitializeComponent();
        }

        private void btnAdaugRez_Click(object sender, EventArgs e)
        {
            AdaugaRezervari adr = new AdaugaRezervari(id,nume,prenume,email,telefon);
            adr.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VizualizareRezervari vr = new VizualizareRezervari();
            vr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grafice gf = new Grafice();
            gf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
