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
    public partial class FormProdusMod : Form
    {
        public Produse p;
        public Adauga_Meniu parinte;
        public FormProdusMod()
        {
            InitializeComponent();
        }

       public void ActualizeazaButoane(object sender, EventArgs e)
        {
            ListView mylist = (ListView)sender;

            if (mylist.SelectedItems.Count > 0)
                p = (Produse)mylist.SelectedItems[0].Tag;

            if (p != null)
            {
                tbDenumire.Text = p.Denumire;
                tbCateg.Text = p.Categorie;
                tbPret.Text = p.Pret.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if (tbDenumire.Text == "")
            {
                eroare = true;
                errorProvider1.SetError(tbDenumire, "Denumirea nu poate fi nulă!");
            }

            if (tbPret == null)
            {
                errorProvider1.SetError(tbPret, "NU poate fi null!");
            }
            if (p != null && !eroare)
            {
                this.DialogResult = DialogResult.OK;
                p.Denumire = tbDenumire.Text;
                p.Categorie = tbCateg.Text;


                p.Pret = Convert.ToDouble(tbPret.Text);
                parinte.UpdateItems();
            }
            Dispose();
        }

        private void tbPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCateg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDenumire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Denumire_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
