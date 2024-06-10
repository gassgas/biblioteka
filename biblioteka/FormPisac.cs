using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace biblioteka
{
    public partial class FormPisac : Form
    {


        public int indeks;
        public FormPisac()
        {
            InitializeComponent();
        }
        public FormPisac(Pisac p, int indeks)
        {
            InitializeComponent();
            this.indeks = indeks;
            cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPol_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btDesno_Click(object sender, EventArgs e)
        {
            indeks++;
            if (indeks > Data.ListaPisaca.Count) indeks = 1;
            Pisac p = Data.pomeranjePisca(indeks);
            cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();

        }

        private void btLevo_Click(object sender, EventArgs e)
        {
            indeks--;
            if (indeks <= 0) indeks = Data.ListaPisaca.Count;
            Pisac p = Data.pomeranjePisca(indeks);
            cbStatusPisca.Text = p.Status;
            txtImePisca.Text = p.Ime;
            txtPrezimePisca.Text = p.Prezime;
            cbPol.Text = p.Pol;
            txtGodinaRodjenjaPisca.Text = p.GodinaRodjenja.ToString();

            txtNapomenePisca.Lines = p.Napomena.ToArray();

        }
    }
}
