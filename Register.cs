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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nume = tbNume.Text;
            string Prenume = tbPrenume.Text;
            string Telefon = tbTelefon.Text;
            string Email = tbMail.Text;
            string Varsta = tbVarsta.Text;
            string Oras = tbOras.Text;
            string Nume_Cont = tbNume_Cont.Text;
            string Parola = tbParola.Text;

            bool er = false;
            if (tbNume.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbNume, "Numele nu poate fi null!");
            }
            else if (tbPrenume.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbPrenume, "Prenumele nu poate fi null!");
            }
            else if (tbTelefon.Text.Length != 10)
            {
                er = true;
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa fie 10!");
            }

            else if (Convert.ToInt32(tbVarsta.Text) < 0)
            {
                er = true;
                errorProvider1.SetError(tbVarsta, "Varsta invalida!");
            }
            else if (tbOras.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbOras, "Numele orasului nu poate fi null!");
            }
            else if (tbMail.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbMail, "Emailul nu poate fi null!");
            }
            else if (tbNume_Cont.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbNume_Cont, "Numele contului nu poate fi null!");
            }
            else if (tbParola.Text == "")
            {
                er = true;
                errorProvider1.SetError(tbParola, "Parola invalida!");
            }


            if (er == false)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(ID) FROM Utilizatori";
                    int id = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO Utilizatori VALUES(?,?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                    comanda.Parameters.Add("Nume", OleDbType.Char, 50).Value = tbNume.Text;
                    comanda.Parameters.Add("Prenume", OleDbType.Char, 50).Value = tbPrenume.Text;
                    comanda.Parameters.Add("Email", OleDbType.Char, 50).Value = tbMail.Text;
                    comanda.Parameters.Add("Telefon", OleDbType.Integer).Value = Convert.ToInt32(tbTelefon.Text);
                    comanda.Parameters.Add("Varsta", OleDbType.Integer).Value = tbVarsta.Text;
                    comanda.Parameters.Add("Parola", OleDbType.Char, 50).Value = tbParola.Text;
                    comanda.Parameters.Add("Nume_Cont", OleDbType.Char, 50).Value = tbNume_Cont.Text;
                    comanda.Parameters.Add("Oras", OleDbType.Char, 50).Value = tbOras.Text;
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
                    tbTelefon.Clear();
                    tbPrenume.Clear();
                    tbNume.Clear();
                    tbMail.Clear();
                    tbOras.Clear();
                    tbParola.Clear();
                    tbNume_Cont.Clear();
                    tbParola.Clear();
                }
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    }

