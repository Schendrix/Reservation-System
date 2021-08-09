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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT Parola FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                    string parola = Convert.ToString(comanda.ExecuteScalar());
                    comanda.CommandText = "SELECT Parola FROM Administrator where User ='" + tbUser.Text + "'";
                    string parola1 = Convert.ToString(comanda.ExecuteScalar());
                    if (parola == tbPass.Text && tbUser.Text != "" && tbPass.Text != "")
                    {
                        comanda.CommandText = "SELECT ID FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT Nume FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                        string nume = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT Prenume FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                        string prenume = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT Email FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                        string email = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT Telefon FROM Utilizatori where Nume_Cont ='" + tbUser.Text + "'";
                        string telefon = Convert.ToString(comanda.ExecuteScalar());
                        Clienti c = new Clienti(id,nume,prenume,email,telefon);
                        c.ShowDialog();
                    }
                    else if (parola1 == tbPass.Text && tbUser.Text != "" && tbPass.Text != "")
                    {
                            Admin admin = new Admin();
                            admin.ShowDialog();
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


            string User = tbUser.Text;
            string Parola = tbPass.Text;
            if (User == "")
            {
                errorProvider1.SetError(tbUser, "Userul nu poate fi nul!");
            }
            else if (Parola == "")
            {
                errorProvider1.SetError(tbPass, "Parola nu poate fi nula!");
            }
            else
            {
                tbUser.Clear();
                tbPass.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {   
            tbPass.UseSystemPasswordChar = true;    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
        
    
}
