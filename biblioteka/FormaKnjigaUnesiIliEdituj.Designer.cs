
namespace biblioteka
{
    partial class FormaKnjigaUnesiIliEdituj
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
            this.cbPisci = new System.Windows.Forms.ComboBox();
            this.btEditKnjiga = new System.Windows.Forms.Button();
            this.btDodajKnjigu = new System.Windows.Forms.Button();
            this.lblPronadjenaKnjiga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPisci
            // 
            this.cbPisci.FormattingEnabled = true;
            this.cbPisci.Location = new System.Drawing.Point(446, 253);
            this.cbPisci.Name = "cbPisci";
            this.cbPisci.Size = new System.Drawing.Size(229, 24);
            this.cbPisci.TabIndex = 5;
            this.cbPisci.SelectedIndexChanged += new System.EventHandler(this.cbPisci_SelectedIndexChanged);
            // 
            // btEditKnjiga
            // 
            this.btEditKnjiga.Location = new System.Drawing.Point(446, 174);
            this.btEditKnjiga.Name = "btEditKnjiga";
            this.btEditKnjiga.Size = new System.Drawing.Size(229, 73);
            this.btEditKnjiga.TabIndex = 4;
            this.btEditKnjiga.Text = "Edituj Knjigu";
            this.btEditKnjiga.UseVisualStyleBackColor = true;
            this.btEditKnjiga.Click += new System.EventHandler(this.btEditKnjiga_Click);
            // 
            // btDodajKnjigu
            // 
            this.btDodajKnjigu.Location = new System.Drawing.Point(126, 174);
            this.btDodajKnjigu.Name = "btDodajKnjigu";
            this.btDodajKnjigu.Size = new System.Drawing.Size(229, 73);
            this.btDodajKnjigu.TabIndex = 3;
            this.btDodajKnjigu.Text = "Dodaj Knjigu";
            this.btDodajKnjigu.UseVisualStyleBackColor = true;
            this.btDodajKnjigu.Click += new System.EventHandler(this.btDodajKnjigu_Click);
            // 
            // lblPronadjenaKnjiga
            // 
            this.lblPronadjenaKnjiga.AutoSize = true;
            this.lblPronadjenaKnjiga.Location = new System.Drawing.Point(170, 366);
            this.lblPronadjenaKnjiga.Name = "lblPronadjenaKnjiga";
            this.lblPronadjenaKnjiga.Size = new System.Drawing.Size(47, 17);
            this.lblPronadjenaKnjiga.TabIndex = 9;
            this.lblPronadjenaKnjiga.Text = "Knjiga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(173, 327);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(179, 22);
            this.txtPretraga.TabIndex = 8;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(170, 294);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(63, 17);
            this.lblPretraga.TabIndex = 7;
            this.lblPretraga.Text = "Pretraga";
            // 
            // FormaKnjigaUnesiIliEdituj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPronadjenaKnjiga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.cbPisci);
            this.Controls.Add(this.btEditKnjiga);
            this.Controls.Add(this.btDodajKnjigu);
            this.Name = "FormaKnjigaUnesiIliEdituj";
            this.Text = "FormaKnjigaUnesiIliEdituj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPisci;
        private System.Windows.Forms.Button btEditKnjiga;
        private System.Windows.Forms.Button btDodajKnjigu;
        private System.Windows.Forms.Label lblPronadjenaKnjiga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
    }
}