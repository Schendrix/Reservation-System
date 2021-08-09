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
    public partial class Gest_Clienti : Form
    {
        public Gest_Clienti()
        {
            InitializeComponent();
        }

        private void Gest_Clienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplicatie_GestionareDS.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.aplicatie_GestionareDS.Utilizatori);

        }
    }
}
