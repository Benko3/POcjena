namespace Prosjek_ocjena2
{
    partial class Form1
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
            this.Predmeti = new System.Windows.Forms.ComboBox();
            this.Unesi = new System.Windows.Forms.Button();
            this.Spremi = new System.Windows.Forms.Button();
            this.Ispisi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ocjena = new System.Windows.Forms.TextBox();
            this.Ucitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Predmeti
            // 
            this.Predmeti.FormattingEnabled = true;
            this.Predmeti.Location = new System.Drawing.Point(48, 12);
            this.Predmeti.Name = "Predmeti";
            this.Predmeti.Size = new System.Drawing.Size(461, 28);
            this.Predmeti.TabIndex = 0;
            // 
            // Unesi
            // 
            this.Unesi.Location = new System.Drawing.Point(662, 145);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(97, 47);
            this.Unesi.TabIndex = 1;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = true;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // Spremi
            // 
            this.Spremi.Location = new System.Drawing.Point(569, 213);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(205, 85);
            this.Spremi.TabIndex = 2;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            this.Spremi.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ispisi
            // 
            this.Ispisi.Location = new System.Drawing.Point(569, 348);
            this.Ispisi.Name = "Ispisi";
            this.Ispisi.Size = new System.Drawing.Size(205, 90);
            this.Ispisi.TabIndex = 3;
            this.Ispisi.Text = "Ispisi";
            this.Ispisi.UseVisualStyleBackColor = true;
            this.Ispisi.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 379);
            this.textBox1.TabIndex = 4;
            // 
            // Ocjena
            // 
            this.Ocjena.Location = new System.Drawing.Point(536, 147);
            this.Ocjena.Multiline = true;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.Size = new System.Drawing.Size(100, 45);
            this.Ocjena.TabIndex = 5;
            // 
            // Ucitaj
            // 
            this.Ucitaj.Location = new System.Drawing.Point(536, 17);
            this.Ucitaj.Name = "Ucitaj";
            this.Ucitaj.Size = new System.Drawing.Size(223, 96);
            this.Ucitaj.TabIndex = 6;
            this.Ucitaj.Text = "Ucitaj";
            this.Ucitaj.UseVisualStyleBackColor = true;
            this.Ucitaj.Click += new System.EventHandler(this.Ucitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ucitaj);
            this.Controls.Add(this.Ocjena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ispisi);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.Unesi);
            this.Controls.Add(this.Predmeti);
            this.Name = "Form1";
            this.Text = "Predmeti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Predmeti;
        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Button Ispisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Ocjena;
        private System.Windows.Forms.Button Ucitaj;
    }
}

