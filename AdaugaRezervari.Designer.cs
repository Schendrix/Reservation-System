
namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    partial class AdaugaRezervari
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
            this.components = new System.ComponentModel.Container();
            this.tbNrPersoane = new System.Windows.Forms.TextBox();
            this.tbMasa = new System.Windows.Forms.TextBox();
            this.tbOsp = new System.Windows.Forms.TextBox();
            this.btnAdaugaRez = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbPlata = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNrPersoane
            // 
            this.tbNrPersoane.BackColor = System.Drawing.Color.Moccasin;
            this.tbNrPersoane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNrPersoane.Location = new System.Drawing.Point(190, 182);
            this.tbNrPersoane.Name = "tbNrPersoane";
            this.tbNrPersoane.Size = new System.Drawing.Size(100, 20);
            this.tbNrPersoane.TabIndex = 5;
            // 
            // tbMasa
            // 
            this.tbMasa.BackColor = System.Drawing.Color.Moccasin;
            this.tbMasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMasa.Location = new System.Drawing.Point(190, 237);
            this.tbMasa.Name = "tbMasa";
            this.tbMasa.Size = new System.Drawing.Size(100, 20);
            this.tbMasa.TabIndex = 6;
            // 
            // tbOsp
            // 
            this.tbOsp.BackColor = System.Drawing.Color.Moccasin;
            this.tbOsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOsp.Location = new System.Drawing.Point(190, 377);
            this.tbOsp.Name = "tbOsp";
            this.tbOsp.Size = new System.Drawing.Size(100, 20);
            this.tbOsp.TabIndex = 8;
            // 
            // btnAdaugaRez
            // 
            this.btnAdaugaRez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdaugaRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaRez.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdaugaRez.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAdaugaRez.Location = new System.Drawing.Point(119, 516);
            this.btnAdaugaRez.Name = "btnAdaugaRez";
            this.btnAdaugaRez.Size = new System.Drawing.Size(100, 40);
            this.btnAdaugaRez.TabIndex = 9;
            this.btnAdaugaRez.Text = "Rezerva";
            this.btnAdaugaRez.UseVisualStyleBackColor = false;
            this.btnAdaugaRez.Click += new System.EventHandler(this.btnAdaugaRez_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cbPlata
            // 
            this.cbPlata.BackColor = System.Drawing.Color.Moccasin;
            this.cbPlata.FormattingEnabled = true;
            this.cbPlata.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbPlata.Location = new System.Drawing.Point(190, 300);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(100, 21);
            this.cbPlata.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Rezervare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numar Persoane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nr. Masa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tip Plata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id Ospatar";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Bisque;
            this.button1.Image = global::PAW_Proiect_Gestionare_Rezervari_Restaurante.Properties.Resources.back__2_;
            this.button1.Location = new System.Drawing.Point(30, 516);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Back";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdaugaRezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(354, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdaugaRez);
            this.Controls.Add(this.tbOsp);
            this.Controls.Add(this.tbMasa);
            this.Controls.Add(this.tbNrPersoane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdaugaRezervari";
            this.Text = "AdaugaRezervari";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNrPersoane;
        private System.Windows.Forms.TextBox tbMasa;
        private System.Windows.Forms.TextBox tbOsp;
        private System.Windows.Forms.Button btnAdaugaRez;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbPlata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}