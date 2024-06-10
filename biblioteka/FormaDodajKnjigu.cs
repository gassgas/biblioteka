using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class FormaDodajKnjigu : Form
    {

    


        public int indeks;
        public FormaDodajKnjigu()
        {
            InitializeComponent();


            

        }

        public void popuniComboBoxeve()
        {
            //dodaj i za sva izdavanja i jos nesto ako ima
            for (int i = 0; i < Data.ListaPisaca.Count; i++)
            {
                clbPisci.Items.Add(Data.ListaPisaca[i].Ime);
            }
        }

        public FormaDodajKnjigu(Knjiga k, int indeks)
        {
            InitializeComponent();

            this.indeks = indeks;
            cbStatus.Text = k.Status;
            txtNaziv.Text = k.Naziv;


            for (int i = 0; i < k.Pisac.Count; i++)
            {
                clbPisci.Text += k.Pisac[i].ToString() + '\n';
            }

            cbZanr.Text = k.Zanr;
            txtRedniBrojIzdanja.Text = k.RedniBrojIzdanja.ToString();
            txtGodinaIzdavanja.Text = k.GodinaIzdavanja.ToString();
            txtIzdavac.Text = k.Izdavac;
            txtISBN.Text = k.ISBN;
            txtStanje.Text = k.Stanje;
            cbProstorija.Text = k.Prostorija;
            cbPolica.Text = k.Polica;
            txtUkupanBrojPrimeraka.Text = k.UkupanBrojPrimeraka.ToString();

            for (int i = 0; i < k.SvaIzdavanja.Count; i++)
            {
                clbSvaIzdavanja.Text += k.SvaIzdavanja[i].ToString() + '\n';
            }

            cbCitalac.Text = k.Citalac;
            txtDatumIzdavanja.Text = k.DatumIzdavanja.ToString();
            txtRokZaVracanje.Text = k.RokZaVracanje.ToString();
            cbBibliotekar.Text = k.Bibliotekar;
            txtNapomene.Lines = k.Napomena.ToArray();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {

        }

        private void btDesno_Click(object sender, EventArgs e)
        {
            /*indeks--;
            if (indeks < 0) indeks = Data.ListaPisaca.Count;
            Pisac p = Data.pomeranjePisca(indeks);*/
            

            indeks++;
            if (indeks > Data.ListaKnjiga.Count) indeks = 1;
            Knjiga k = Data.pomeranjeKnjige(indeks);

            cbStatus.Text = k.Status;
            txtNaziv.Text = k.Naziv;


            for (int i = 0; i < k.Pisac.Count; i++)
            {
                clbPisci.Text += k.Pisac[i].ToString() + '\n';
            }

            cbZanr.Text = k.Zanr;
            txtRedniBrojIzdanja.Text = k.RedniBrojIzdanja.ToString();
            txtGodinaIzdavanja.Text = k.GodinaIzdavanja.ToString();
            txtIzdavac.Text = k.Izdavac;
            txtISBN.Text = k.ISBN;
            txtStanje.Text = k.Stanje;
            cbProstorija.Text = k.Prostorija;
            cbPolica.Text = k.Polica;
            txtUkupanBrojPrimeraka.Text = k.UkupanBrojPrimeraka.ToString();

            for (int i = 0; i < k.SvaIzdavanja.Count; i++)
            {
                clbSvaIzdavanja.Text += k.SvaIzdavanja[i].ToString() + '\n';
            }

            cbCitalac.Text = k.Citalac;
            txtDatumIzdavanja.Text = k.DatumIzdavanja.ToString();
            txtRokZaVracanje.Text = k.RokZaVracanje.ToString();
            cbBibliotekar.Text = k.Bibliotekar;
            txtNapomene.Lines = k.Napomena.ToArray();

        }

        private void btLevo_Click(object sender, EventArgs e)
        {

            /*indeks--;
            if (indeks < 0) indeks = Data.ListaPisaca.Count;
            Pisac p = Data.pomeranjePisca(indeks);*/


            indeks--;
            if (indeks <= 0) indeks = Data.ListaKnjiga.Count;
            Knjiga k = Data.pomeranjeKnjige(indeks);

            cbStatus.Text = k.Status;
            txtNaziv.Text = k.Naziv;


            for (int i = 0; i < k.Pisac.Count; i++)
            {
                clbPisci.Text += k.Pisac[i].ToString() + '\n';
            }

            cbZanr.Text = k.Zanr;
            txtRedniBrojIzdanja.Text = k.RedniBrojIzdanja.ToString();
            txtGodinaIzdavanja.Text = k.GodinaIzdavanja.ToString();
            txtIzdavac.Text = k.Izdavac;
            txtISBN.Text = k.ISBN;
            txtStanje.Text = k.Stanje;
            cbProstorija.Text = k.Prostorija;
            cbPolica.Text = k.Polica;
            txtUkupanBrojPrimeraka.Text = k.UkupanBrojPrimeraka.ToString();

            for (int i = 0; i < k.SvaIzdavanja.Count; i++)
            {
                clbSvaIzdavanja.Text += k.SvaIzdavanja[i].ToString() + '\n';
            }

            cbCitalac.Text = k.Citalac;
            txtDatumIzdavanja.Text = k.DatumIzdavanja.ToString();
            txtRokZaVracanje.Text = k.RokZaVracanje.ToString();
            cbBibliotekar.Text = k.Bibliotekar;
            txtNapomene.Lines = k.Napomena.ToArray();
        }

        private void FormaDodajKnjigu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("radi");
        }

        private void FormaDodajKnjigu_Load(object sender, EventArgs e)
        {
            popuniComboBoxeve();
        }
    }
}
