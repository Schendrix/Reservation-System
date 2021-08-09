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
    public partial class VizualizareRezervari : Form
    {
        public VizualizareRezervari()
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
                comanda.CommandText = "SELECT * FROM Rezervari where Nume = '" + Clienti.nume + "'";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Prenume"].ToString());
                    itm.SubItems.Add(reader["Data"].ToString());
                    itm.SubItems.Add(reader["Nr_Persoane"].ToString());
                    itm.SubItems.Add(reader["Masa"].ToString());
                    itm.SubItems.Add(reader["Tip_Plata"].ToString());
                    itm.SubItems.Add(reader["Id_Ospatar"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
