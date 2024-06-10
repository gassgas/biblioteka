namespace biblioteka
{
    partial class POLICA2
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
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.Lorem = new System.Windows.Forms.TextBox();
            this.Ipsum = new System.Windows.Forms.TextBox();
            this.Dolor = new System.Windows.Forms.TextBox();
            this.Sit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.Location = new System.Drawing.Point(12, 116);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(75, 23);
            this.Sacuvaj.TabIndex = 0;
            this.Sacuvaj.Text = "button1";
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // Lorem
            // 
            this.Lorem.Location = new System.Drawing.Point(12, 12);
            this.Lorem.Name = "Lorem";
            this.Lorem.Size = new System.Drawing.Size(100, 20);
            this.Lorem.TabIndex = 1;
            // 
            // Ipsum
            // 
            this.Ipsum.Location = new System.Drawing.Point(12, 38);
            this.Ipsum.Name = "Ipsum";
            this.Ipsum.Size = new System.Drawing.Size(100, 20);
            this.Ipsum.TabIndex = 2;
            // 
            // Dolor
            // 
            this.Dolor.Location = new System.Drawing.Point(12, 64);
            this.Dolor.Name = "Dolor";
            this.Dolor.Size = new System.Drawing.Size(100, 20);
            this.Dolor.TabIndex = 3;
            // 
            // Sit
            // 
            this.Sit.Location = new System.Drawing.Point(12, 90);
            this.Sit.Name = "Sit";
            this.Sit.Size = new System.Drawing.Size(100, 20);
            this.Sit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ovde Treba Da Se Nalazi ID Police Koja Se Trenutno Unosi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ovde Treba Da Se Nalazi Sta Pise Na Polici Koja Se Trenutno Unosi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oved Treba Da Se Nalazi Ime Prostorije U Kojoj Se Nalazi Polica Koja Se Trenutno " +
    "Unosi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(880, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ovde Treba Da Se Nalazi Bilo Sta, Moze I Da Ostane Prazno, Ali Mora Da Postoji za" +
    "to Sta Mozda Nekada Bude Bilo Potrebno Ako Neko Provali Zemu Napomena Sluzi I Ka" +
    "ko Se Koristi";
            // 
            // POLICA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sit);
            this.Controls.Add(this.Dolor);
            this.Controls.Add(this.Ipsum);
            this.Controls.Add(this.Lorem);
            this.Controls.Add(this.Sacuvaj);
            this.Name = "POLICA2";
            this.Text = "POLICA2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sacuvaj;
        private System.Windows.Forms.TextBox Lorem;
        private System.Windows.Forms.TextBox Ipsum;
        private System.Windows.Forms.TextBox Dolor;
        private System.Windows.Forms.TextBox Sit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}