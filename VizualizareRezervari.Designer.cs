
namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    partial class VizualizareRezervari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_Persoane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_Plata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Ospatar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfis
            // 
            this.btnAfis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAfis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfis.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAfis.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAfis.Location = new System.Drawing.Point(317, 390);
            this.btnAfis.Name = "btnAfis";
            this.btnAfis.Size = new System.Drawing.Size(175, 34);
            this.btnAfis.TabIndex = 1;
            this.btnAfis.Text = "Afiseaza";
            this.btnAfis.UseVisualStyleBackColor = false;
            this.btnAfis.Click += new System.EventHandler(this.btnAfis_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SandyBrown;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Data,
            this.Nr_Persoane,
            this.Masa,
            this.Tip_Plata,
            this.Id_Ospatar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(540, 235);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 113;
            // 
            // Nr_Persoane
            // 
            this.Nr_Persoane.Text = "Nr_Persoane";
            this.Nr_Persoane.Width = 87;
            // 
            // Masa
            // 
            this.Masa.Text = "Masa";
            // 
            // Tip_Plata
            // 
            this.Tip_Plata.Text = "Tip_Plata";
            this.Tip_Plata.Width = 85;
            // 
            // Id_Ospatar
            // 
            this.Id_Ospatar.Text = "Id_Ospatar";
            this.Id_Ospatar.Width = 70;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Bisque;
            this.button1.Image = global::PAW_Proiect_Gestionare_Rezervari_Restaurante.Properties.Resources.back__2_;
            this.button1.Location = new System.Drawing.Point(9, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Back";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VizualizareRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAfis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VizualizareRezervari";
            this.Text = "VizualizareRezervari";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAfis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Nr_Persoane;
        private System.Windows.Forms.ColumnHeader Masa;
        private System.Windows.Forms.ColumnHeader Tip_Plata;
        private System.Windows.Forms.ColumnHeader Id_Ospatar;
        private System.Windows.Forms.Button button1;
    }
}