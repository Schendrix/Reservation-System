using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    public partial class Grafice : Form
    {

        
        
        const int marg = 10;
        Font font1 = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
        Font font2 = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);

        public Grafice()
        {

            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
            conexiune.Open();
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(Varsta) FROM Utilizatori where Varsta >18 ";
            int varstamaj = Convert.ToInt32(comanda.ExecuteScalar());
            comanda.CommandText = "SELECT COUNT(Varsta) FROM Utilizatori where Varsta <18 ";
            int varstamin = Convert.ToInt32(comanda.ExecuteScalar());
            conexiune.Close();
            int varsta1 = varstamaj * 360 / (varstamaj + varstamin);
            int varsta2 = 360 - varsta1;

            Graphics gr = e.Graphics;
            Rectangle rec = new Rectangle(46, 86, 256, 257);
            gr.DrawPie(new Pen(Color.Purple, 3), rec, 0, varsta1);
            gr.FillPie(new SolidBrush(Color.Purple), rec, 0, varsta1);
            gr.DrawPie(new Pen(Color.DarkBlue, 3), rec, varsta1, varsta2);
            gr.FillPie(new SolidBrush(Color.DarkBlue), rec, varsta1, varsta2);
            //Legenda
            gr.DrawString("Nr. persoanelor majore (" + varstamaj +")", font1, new SolidBrush(Color.Black), new Point(107, 32));
            Pen pen = new Pen(Color.Purple, 3);
            Rectangle rec2 = new Rectangle(82, 32, 15, 15);
            gr.DrawRectangle(pen, rec2);
            gr.FillRectangle(new SolidBrush(Color.Purple), rec2);

            gr.DrawString("Nr. persoanelor mniore (" + varstamin + ")", font1, new SolidBrush(Color.Black), new Point(107, 56));
            Pen pen2 = new Pen(Color.DarkBlue, 3);
            Rectangle rec3 = new Rectangle(82, 56, 15, 15);
            gr.DrawRectangle(pen2, rec3);
            gr.FillRectangle(new SolidBrush(Color.DarkBlue), rec3);
        }
        private void pdPrintPie(object sender, PrintPageEventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Aplicatie_Gestionare.accdb");
            conexiune.Open();
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(Varsta) FROM Utilizatori where Varsta >18 ";
            int varstamaj = Convert.ToInt32(comanda.ExecuteScalar());
            comanda.CommandText = "SELECT COUNT(Varsta) FROM Utilizatori where Varsta <18 ";
            int varstamin = Convert.ToInt32(comanda.ExecuteScalar());
            conexiune.Close();
            int varsta1 = varstamaj * 360 / (varstamaj + varstamin);
            int varsta2 = 360 - varsta1;

             Graphics gr = e.Graphics;
            Rectangle rec = new Rectangle(46, 86, 256, 257);
            gr.DrawPie(new Pen(Color.Purple, 3), rec, 0, varsta1);
            gr.FillPie(new SolidBrush(Color.Purple), rec, 0, varsta1);
            gr.DrawPie(new Pen(Color.DarkBlue, 3), rec, varsta1, varsta2);
            gr.FillPie(new SolidBrush(Color.DarkBlue), rec, varsta1, varsta2);
            //Legenda
            gr.DrawString("Nr. persoanelor majore (" + varstamaj + ")", font1, new SolidBrush(Color.Black), new Point(107, 32));
            Pen pen = new Pen(Color.Purple, 3);
            Rectangle rec2 = new Rectangle(82, 32, 15, 15);
            gr.DrawRectangle(pen, rec2);
            gr.FillRectangle(new SolidBrush(Color.Purple), rec2);

            gr.DrawString("Nr. persoanelor mniore (" + varstamin + ")", font1, new SolidBrush(Color.Black), new Point(107, 56));
            Pen pen2 = new Pen(Color.DarkBlue, 3);
            Rectangle rec3 = new Rectangle(82, 56, 15, 15);
            gr.DrawRectangle(pen2, rec3);
            gr.FillRectangle(new SolidBrush(Color.DarkBlue), rec3);
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panel1.BackColor = Color.LightBlue;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
            string text = e.Data.GetData(typeof(string)).ToString();
            PrintDocument pd = new PrintDocument();
            if (text == "Pie")
            pd.PrintPage += new PrintPageEventHandler(pdPrintPie);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
            panel1.BackColor = Color.Gainsboro;
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.DoDragDrop("Pie", DragDropEffects.Copy | DragDropEffects.Move);
        }

      

        private void Grafice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
