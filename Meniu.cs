using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            
            InitializeComponent();
        }

        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Produse p = (Produse)lvi.Tag;
                lvi.Text = p.Denumire;
                lvi.SubItems[1].Text = p.Categorie;
                lvi.SubItems[2].Text = p.Pret.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckPathExists = true;
            fd.CheckFileExists = true;
            fd.Filter = "fisiere produse (*.produse)|*.produse";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Produse> lista = (List<Produse>)deserializator.Deserialize(fb);

                listView1.Items.Clear();

                foreach (Produse p in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                    lvi.Tag = p;
                    listView1.Items.Add(lvi);
                }
                UpdateItems();
                fb.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
