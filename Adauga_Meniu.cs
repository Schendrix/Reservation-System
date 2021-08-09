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
    public partial class Adauga_Meniu : Form
    {
        public Adauga_Meniu()
        {
            InitializeComponent();

            Produse produs1 = new Produse("Cola", "Bautura", 4.5);
            Produse produs2 = new Produse("Supa de ciuperci", "Supe", 15);
            Produse produs3 = new Produse("Burger", "Burgeri", 30);

            ListViewItem lvi1 = new ListViewItem(produs1.Denumire);
            lvi1.SubItems.Add(produs1.Categorie);
            lvi1.SubItems.Add(produs1.Pret.ToString());
            lvi1.Tag = produs1;
            listView1.Items.Add(lvi1);

            ListViewItem lvi2 = new ListViewItem(produs2.Denumire);
            lvi2.SubItems.Add(produs2.Categorie);
            lvi2.SubItems.Add(produs2.Pret.ToString());
            lvi2.Tag = produs2;
            listView1.Items.Add(lvi2);

            ListViewItem lvi3 = new ListViewItem(produs3.Denumire);
            lvi3.SubItems.Add(produs3.Categorie);
            lvi3.SubItems.Add(produs3.Pret.ToString());
            lvi3.Tag = produs3;
            listView1.Items.Add(lvi3);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "" });
            listView1.Items.Add(lvi);
            Produse pro = new Produse("", "", 0);
            lvi.Tag=pro;
            lvi.Selected = true;

            FormProdAdd fpa = new FormProdAdd();
            fpa.Show();
            fpa.p = pro;
            fpa.parinte = this;
            fpa.Text = "Adauga Produs";
            

        }

        public void UpdateItems()
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                Produse p = (Produse)lvi.Tag;
                lvi.Text = p.Denumire;
                lvi.SubItems[1].Text = p.Categorie;
                lvi.SubItems[2].Text = p.Pret.ToString();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                FormProdusMod fp = new FormProdusMod();
                listView1.SelectedIndexChanged += new EventHandler(fp.ActualizeazaButoane);
                fp.Text = "Modifica Produs";
                fp.ActualizeazaButoane(listView1, e);
                fp.parinte = this;
                fp.Show();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Produse p = (Produse)listView1.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea produsului " + p.Denumire + " ?",
                    "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes) listView1.SelectedItems[0].Remove();
            }
        }

        private void inBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere produse (*.produse)|*.produse";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Produse> lista = listView1.Items.Cast<ListViewItem>()
                                .Select(item => (Produse)item.Tag)
                                .ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }

        private void btnRestaureaza_Click(object sender, EventArgs e)
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
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", ""});
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
