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
    public partial class AdaugaRezervari : Form
    {
        public static int id;
        public static string nume;
        public static string prenume;
        public static string email;
        public static string telefon;
        public AdaugaRezervari(int id, string nume, string prenume, string email, string telefon)
        {
            InitializeComponent();
            AdaugaRezervari.id = id;
            AdaugaRezervari.nume = nume;
            AdaugaRezervari.prenume = prenume;
            AdaugaRezervari.email = email;
            AdaugaRezervari.telefon = telefon;

        }


        private void btnAdaugaRez_Click(object sender, EventArgs e)
        {

            int nrPers = Convert.ToInt32(tbNrPersoane.Text);
            int masa = Convert.ToInt32(tbMasa.Text);
            string tip = cbPlata.Text;
            int nrOspatar = Convert.ToInt32(tbOsp.Text);
            DateTime data = dateTimePicker1.Value;

            // string confPass = tbCParola.Text;

            if (tbNrPersoane.Text == "" || tbMasa.Text == "" || cbPlata.Text == "" || tbOsp.Text == "")
            {
                MessageBox.Show("Unul dintre rânduri este gol!");
            }
            if (nrPers>5)
            {
                errorProvider1.SetError(tbNrPersoane, "Numarul de persoane este prea mare!");
            } else if (masa > 5)
            {
                errorProvider1.SetError(tbMasa, "Numarul mesei este prea mare!");
            }
            else if (nrOspatar > 5)
            {
                errorProvider1.SetError(tbOsp, "ID-ul Ospatarului nu exista!");
            }


            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(ID) FROM Rezervari";
                int id = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO Rezervari VALUES(?,?,?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("Nume", OleDbType.Char, 50).Value = nume;
                comanda.Parameters.Add("Prenume", OleDbType.Char, 50).Value = prenume;
                comanda.Parameters.Add("Data", OleDbType.Date).Value = data;
                comanda.Parameters.Add("Nr_Persoane", OleDbType.Integer).Value = nrPers;
                comanda.Parameters.Add("Telefon", OleDbType.Integer).Value = telefon;
                comanda.Parameters.Add("Email", OleDbType.Char, 50).Value = email;
                comanda.Parameters.Add("Masa", OleDbType.Integer).Value = masa;
                comanda.Parameters.Add("Tip_Plata", OleDbType.Char, 50).Value = tip;
                comanda.Parameters.Add("Id_Ospatar", OleDbType.Integer).Value = nrOspatar;
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*   if (Nume == "")
               {
                   errorProvider1.SetError(tbNume, "Numele nu poate fi null!");
               } */

            finally
            {
                conexiune.Close();
                tbNrPersoane.Clear();
                tbMasa.Clear();
                tbOsp.Clear();
                ((Form)this.TopLevelControl).Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
