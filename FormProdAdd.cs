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
    public partial class FormProdAdd : Form
    {
        public Produse p;
        public Adauga_Meniu parinte;
        public FormProdAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                Dispose();
            }
   
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

   
}
