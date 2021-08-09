
namespace PAW_Proiect_Gestionare_Rezervari_Restaurante
{
    partial class FormProdusMod
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Denumire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbCateg = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Denumire
            // 
            this.Denumire.AutoSize = true;
            this.Denumire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Denumire.Location = new System.Drawing.Point(32, 81);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(85, 19);
            this.Denumire.TabIndex = 1;
            this.Denumire.Text = "Denumire";
            this.Denumire.Click += new System.EventHandler(this.Denumire_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categorie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pret";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.BackColor = System.Drawing.Color.Moccasin;
            this.tbDenumire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDenumire.Location = new System.Drawing.Point(123, 80);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 4;
            this.tbDenumire.TextChanged += new System.EventHandler(this.tbDenumire_TextChanged);
            // 
            // tbCateg
            // 
            this.tbCateg.BackColor = System.Drawing.Color.Moccasin;
            this.tbCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCateg.Location = new System.Drawing.Point(123, 161);
            this.tbCateg.Name = "tbCateg";
            this.tbCateg.Size = new System.Drawing.Size(100, 20);
            this.tbCateg.TabIndex = 5;
            this.tbCateg.TextChanged += new System.EventHandler(this.tbCateg_TextChanged);
            // 
            // tbPret
            // 
            this.tbPret.BackColor = System.Drawing.Color.Moccasin;
            this.tbPret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPret.Location = new System.Drawing.Point(123, 267);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 20);
            this.tbPret.TabIndex = 6;
            this.tbPret.TextChanged += new System.EventHandler(this.tbPret_TextChanged);
            // 
            // button1
            // 
            this.button1.AccessibleName = "buttonmod";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(89, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Bisque;
            this.button2.Image = global::PAW_Proiect_Gestionare_Rezervari_Restaurante.Properties.Resources.back__2_;
            this.button2.Location = new System.Drawing.Point(9, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "&Back";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormProdusMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(254, 460);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCateg);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Denumire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProdusMod";
            this.Text = "FormProdus";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCateg;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Denumire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}