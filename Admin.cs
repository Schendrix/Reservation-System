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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adauga_Meniu am = new Adauga_Meniu();
            am.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestionare_Clienti gc = new Gestionare_Clienti();
            gc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grafice gf = new Grafice();
            gf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
