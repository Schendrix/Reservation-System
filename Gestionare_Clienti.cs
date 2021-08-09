using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    public partial class Gestionare_Clienti : Form
    {
        public Gestionare_Clienti()
        {
            InitializeComponent();
        }

        private void btnAfis_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
            try
            {
                listView1.Items.Clear();
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Utilizatori ";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Prenume"].ToString());
                    itm.SubItems.Add(reader["Email"].ToString());
                    itm.SubItems.Add(reader["Telefon"].ToString());
                    itm.SubItems.Add(reader["Varsta"].ToString());
                    itm.SubItems.Add(reader["Nume_Cont"].ToString());
                    itm.SubItems.Add(reader["Parola"].ToString());
                    itm.SubItems.Add(reader["Oras"].ToString());
                    listView1.Items.Add(itm);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int id = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "Delete from Utilizatori where ID =" + id;
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
