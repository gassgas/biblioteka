namespace biblioteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.potvrdi = new System.Windows.Forms.Button();
            this.izdavanje_knjiga = new System.Windows.Forms.Button();
            this.vracanje_knjiga = new System.Windows.Forms.Button();
            this.pisac = new System.Windows.Forms.Button();
            this.knjiga = new System.Windows.Forms.Button();
            this.prostorija = new System.Windows.Forms.Button();
            this.polica = new System.Windows.Forms.Button();
            this.bibliotekar = new System.Windows.Forms.Button();
            this.citalac = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.izvestaj = new System.Windows.Forms.Button();
            this.novi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username1
            // 
            this.username1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.username1.ForeColor = System.Drawing.SystemColors.Menu;
            this.username1.Location = new System.Drawing.Point(35, 297);
            this.username1.Margin = new System.Windows.Forms.Padding(2);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(86, 20);
            this.username1.TabIndex = 0;
            this.username1.TextChanged += new System.EventHandler(this.username2);
            // 
            // password1
            // 
            this.password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.password1.ForeColor = System.Drawing.SystemColors.Menu;
            this.password1.Location = new System.Drawing.Point(35, 319);
            this.password1.Margin = new System.Windows.Forms.Padding(2);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(86, 20);
            this.password1.TabIndex = 1;
            this.password1.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // potvrdi
            // 
            this.potvrdi.Location = new System.Drawing.Point(133, 320);
            this.potvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.potvrdi.Name = "potvrdi";
            this.potvrdi.Size = new System.Drawing.Size(45, 19);
            this.potvrdi.TabIndex = 2;
            this.potvrdi.Text = "potvrdi";
            this.potvrdi.UseVisualStyleBackColor = true;
            this.potvrdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // izdavanje_knjiga
            // 
            this.izdavanje_knjiga.Location = new System.Drawing.Point(26, 199);
            this.izdavanje_knjiga.Margin = new System.Windows.Forms.Padding(2);
            this.izdavanje_knjiga.Name = "izdavanje_knjiga";
            this.izdavanje_knjiga.Size = new System.Drawing.Size(94, 19);
            this.izdavanje_knjiga.TabIndex = 3;
            this.izdavanje_knjiga.Text = "izdavanje knjiga";
            this.izdavanje_knjiga.UseVisualStyleBackColor = true;
            this.izdavanje_knjiga.Click += new System.EventHandler(this.izdavanje_knjiga_Click);
            // 
            // vracanje_knjiga
            // 
            this.vracanje_knjiga.Location = new System.Drawing.Point(35, 98);
            this.vracanje_knjiga.Margin = new System.Windows.Forms.Padding(2);
            this.vracanje_knjiga.Name = "vracanje_knjiga";
            this.vracanje_knjiga.Size = new System.Drawing.Size(90, 19);
            this.vracanje_knjiga.TabIndex = 4;
            this.vracanje_knjiga.Text = "vracanje knjiga";
            this.vracanje_knjiga.UseVisualStyleBackColor = true;
            this.vracanje_knjiga.Click += new System.EventHandler(this.vracanje_knjiga_Click);
            // 
            // pisac
            // 
            this.pisac.Location = new System.Drawing.Point(399, 196);
            this.pisac.Margin = new System.Windows.Forms.Padding(2);
            this.pisac.Name = "pisac";
            this.pisac.Size = new System.Drawing.Size(44, 19);
            this.pisac.TabIndex = 5;
            this.pisac.Text = "pisac";
            this.pisac.UseVisualStyleBackColor = true;
            this.pisac.Click += new System.EventHandler(this.pisac_Click);
            // 
            // knjiga
            // 
            this.knjiga.Location = new System.Drawing.Point(621, 196);
            this.knjiga.Margin = new System.Windows.Forms.Padding(2);
            this.knjiga.Name = "knjiga";
            this.knjiga.Size = new System.Drawing.Size(56, 19);
            this.knjiga.TabIndex = 6;
            this.knjiga.Text = "knjiga";
            this.knjiga.UseVisualStyleBackColor = true;
            this.knjiga.Click += new System.EventHandler(this.knjiga_Click);
            // 
            // prostorija
            // 
            this.prostorija.Location = new System.Drawing.Point(399, 98);
            this.prostorija.Margin = new System.Windows.Forms.Padding(2);
            this.prostorija.Name = "prostorija";
            this.prostorija.Size = new System.Drawing.Size(56, 19);
            this.prostorija.TabIndex = 7;
            this.prostorija.Text = "prostorija";
            this.prostorija.UseVisualStyleBackColor = true;
            this.prostorija.Click += new System.EventHandler(this.prostorija_Click);
            // 
            // polica
            // 
            this.polica.Location = new System.Drawing.Point(621, 98);
            this.polica.Margin = new System.Windows.Forms.Padding(2);
            this.polica.Name = "polica";
            this.polica.Size = new System.Drawing.Size(56, 19);
            this.polica.TabIndex = 8;
            this.polica.Text = "polica";
            this.polica.UseVisualStyleBackColor = true;
            this.polica.Click += new System.EventHandler(this.polica_Click);
            // 
            // bibliotekar
            // 
            this.bibliotekar.Location = new System.Drawing.Point(494, 264);
            this.bibliotekar.Margin = new System.Windows.Forms.Padding(2);
            this.bibliotekar.Name = "bibliotekar";
            this.bibliotekar.Size = new System.Drawing.Size(66, 19);
            this.bibliotekar.TabIndex = 9;
            this.bibliotekar.Text = "bibliotekar";
            this.bibliotekar.UseVisualStyleBackColor = true;
            this.bibliotekar.Click += new System.EventHandler(this.bibliotekar_Click);
            // 
            // citalac
            // 
            this.citalac.Location = new System.Drawing.Point(621, 257);
            this.citalac.Margin = new System.Windows.Forms.Padding(2);
            this.citalac.Name = "citalac";
            this.citalac.Size = new System.Drawing.Size(56, 19);
            this.citalac.TabIndex = 10;
            this.citalac.Text = "citalac";
            this.citalac.UseVisualStyleBackColor = true;
            this.citalac.Click += new System.EventHandler(this.citalac_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.RosyBrown;
            this.izlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.izlaz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.izlaz.Location = new System.Drawing.Point(380, 362);
            this.izlaz.Margin = new System.Windows.Forms.Padding(2);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(37, 19);
            this.izlaz.TabIndex = 11;
            this.izlaz.Text = "izlaz";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // izvestaj
            // 
            this.izvestaj.Location = new System.Drawing.Point(133, 236);
            this.izvestaj.Margin = new System.Windows.Forms.Padding(2);
            this.izvestaj.Name = "izvestaj";
            this.izvestaj.Size = new System.Drawing.Size(56, 19);
            this.izvestaj.TabIndex = 12;
            this.izvestaj.Text = "izvestaj";
            this.izvestaj.UseVisualStyleBackColor = true;
            // 
            // novi
            // 
            this.novi.Location = new System.Drawing.Point(133, 297);
            this.novi.Margin = new System.Windows.Forms.Padding(2);
            this.novi.Name = "novi";
            this.novi.Size = new System.Drawing.Size(46, 19);
            this.novi.TabIndex = 13;
            this.novi.Text = "novi";
            this.novi.UseVisualStyleBackColor = true;
            this.novi.Click += new System.EventHandler(this.novi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 22);
            this.button1.TabIndex = 14;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.novi);
            this.Controls.Add(this.izvestaj);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.citalac);
            this.Controls.Add(this.bibliotekar);
            this.Controls.Add(this.polica);
            this.Controls.Add(this.prostorija);
            this.Controls.Add(this.knjiga);
            this.Controls.Add(this.pisac);
            this.Controls.Add(this.vracanje_knjiga);
            this.Controls.Add(this.izdavanje_knjiga);
            this.Controls.Add(this.potvrdi);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.username1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Button potvrdi;
        private System.Windows.Forms.Button izdavanje_knjiga;
        private System.Windows.Forms.Button vracanje_knjiga;
        private System.Windows.Forms.Button pisac;
        private System.Windows.Forms.Button knjiga;
        private System.Windows.Forms.Button prostorija;
        private System.Windows.Forms.Button polica;
        private System.Windows.Forms.Button bibliotekar;
        private System.Windows.Forms.Button citalac;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button izvestaj;
        private System.Windows.Forms.Button novi;
        private System.Windows.Forms.Button button1;
    }
}

