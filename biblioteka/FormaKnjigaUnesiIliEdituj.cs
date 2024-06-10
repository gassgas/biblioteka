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
    public partial class FormaKnjigaUnesiIliEdituj : Form
    {


        public int indeksPronadjeneKnjige;

        public FormaKnjigaUnesiIliEdituj()
        {
            InitializeComponent();
            popuniComboBox();
        }


        void popuniComboBox()
        {
            cbPisci.Items.Clear();
            for (int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                cbPisci.Items.Add(Data.ListaKnjiga[i].ID + " " + Data.ListaKnjiga[i].Naziv);
            }
        }


        private void btDodajKnjigu_Click(object sender, EventArgs e)
        {
            FormaDodajKnjigu dodajKnjigu = new FormaDodajKnjigu();
            dodajKnjigu.ShowDialog();
            dodajKnjigu.btDesno.Hide();
            dodajKnjigu.btLevo.Hide();
            if (dodajKnjigu.DialogResult == DialogResult.OK)
            {
                List<string> napomene = new List<string>();
                napomene = dodajKnjigu.txtNapomene.Lines.ToList<string>();

                List<string> pisci = new List<string>();
                for (int i = 0; i < dodajKnjigu.clbPisci.CheckedItems.Count; i++)
                {
                    pisci.Add(dodajKnjigu.clbPisci.CheckedItems[i].ToString());
                }

                List<string> svaIzdanja = new List<string>();
                for (int i = 0; i < dodajKnjigu.clbSvaIzdavanja.CheckedItems.Count; i++)
                {
                    svaIzdanja.Add(dodajKnjigu.clbSvaIzdavanja.CheckedItems[i].ToString());
                }



                Knjiga k = new Knjiga((Data.ListaKnjiga.Count + 1).ToString(),
                    dodajKnjigu.cbStatus.Text,
                    dodajKnjigu.txtNaziv.Text,
                    dodajKnjigu.cbZanr.Text,
                    int.Parse(dodajKnjigu.txtRedniBrojIzdanja.Text),
                    int.Parse(dodajKnjigu.txtGodinaIzdavanja.Text),
                    dodajKnjigu.txtIzdavac.Text,
                    dodajKnjigu.txtISBN.Text,
                    dodajKnjigu.txtStanje.Text,
                    dodajKnjigu.cbProstorija.Text,
                    dodajKnjigu.cbPolica.Text,
                    int.Parse(dodajKnjigu.txtUkupanBrojPrimeraka.Text),
                    dodajKnjigu.cbCitalac.Text,
                    dodajKnjigu.cbBibliotekar.Text,
                    dodajKnjigu.txtDatumIzdavanja.Text,
                    dodajKnjigu.txtRokZaVracanje.Text,
                    svaIzdanja,
                    pisci,
                    napomene);

                Data.DodajKnjigu(k);
                Data.SacuvajKnjige();
                popuniComboBox();

            }
        }

        private void btEditKnjiga_Click(object sender, EventArgs e)
        {
        
            int indeks = cbPisci.SelectedIndex + 1;
            if (indeks == 0)
            {
                indeks = indeksPronadjeneKnjige;
            }
            if (indeks != 0)
            {
                Knjiga k = Data.ListaKnjiga[indeks-1];
                FormaDodajKnjigu dodajKnjigu = new FormaDodajKnjigu(k, indeks);
                dodajKnjigu.ShowDialog();
                dodajKnjigu.btDesno.Show();
                dodajKnjigu.btLevo.Show();
                if (dodajKnjigu.DialogResult == DialogResult.OK)
                {
                    List<string> napomene = new List<string>();

                    Knjiga k2 = Data.pomeranjeKnjige(dodajKnjigu.indeks);

                    napomene = dodajKnjigu.txtNapomene.Lines.ToList<string>();

                    List<string> pisci = new List<string>();
                    for (int i = 0; i < dodajKnjigu.clbPisci.CheckedItems.Count; i++)
                    {
                        pisci.Add(dodajKnjigu.clbPisci.CheckedItems[i].ToString());
                    }

                    List<string> svaIzdavanja = new List<string>();
                    for (int i = 0; i < dodajKnjigu.clbSvaIzdavanja.CheckedItems.Count; i++)
                    {
                        svaIzdavanja.Add(dodajKnjigu.clbSvaIzdavanja.CheckedItems[i].ToString());
                    }

                    k2.Status = dodajKnjigu.cbStatus.Text;
                    k2.Naziv = dodajKnjigu.txtNaziv.Text;
                    k2.Pisac = pisci;
                    k2.Zanr = dodajKnjigu.cbZanr.Text;
                    k2.RedniBrojIzdanja = int.Parse(dodajKnjigu.txtRedniBrojIzdanja.Text);
                    k2.GodinaIzdavanja = int.Parse(dodajKnjigu.txtGodinaIzdavanja.Text);
                    k2.Izdavac = dodajKnjigu.txtIzdavac.Text;
                    k2.ISBN = dodajKnjigu.txtISBN.Text;
                    k2.Stanje = dodajKnjigu.txtStanje.Text;
                    k2.Prostorija = dodajKnjigu.cbProstorija.Text;
                    k2.Polica = dodajKnjigu.cbPolica.Text;
                    k2.UkupanBrojPrimeraka = int.Parse(dodajKnjigu.txtUkupanBrojPrimeraka.Text);
                    k2.SvaIzdavanja = svaIzdavanja;
                    k2.Citalac = dodajKnjigu.cbCitalac.Text;
                    k2.DatumIzdavanja = dodajKnjigu.txtDatumIzdavanja.Text;
                    k2.RokZaVracanje = dodajKnjigu.txtRokZaVracanje.Text;
                    k2.Bibliotekar = dodajKnjigu.cbBibliotekar.Text;
                    k2.Napomena = napomene;

                    Data.SacuvajKnjige();
                    popuniComboBox();
                }
            }





        }

        private void cbPisci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            /*string ime = "";
            string prezime = "";
            bool predji = false;
            for (int i = 0; i < txtPretraga.Text.Length; i++)
            {
                if (txtPretraga.Text[i].Equals(' '))
                {
                    predji = true;
                    continue;
                }
                if (predji == false)
                {
                    ime += txtPretraga.Text[i];
                }
                if (predji == true)
                {
                    prezime += txtPretraga.Text[i];
                }
            }



            for (int i = 0; i < Data.ListaPisaca.Count; i++)
            {
                if (ime == Data.ListaPisaca[i].Ime && prezime == Data.ListaPisaca[i].Prezime)
                {
                    indeksPronadjenogPisca = int.Parse(Data.ListaPisaca[i].ID);
                    lblPronadjenPisac.Text = Data.ListaPisaca[i].ID + " " + ime + " " + prezime;
                }
            }*/


            string naziv = txtPretraga.Text;

            for (int i = 0; i < Data.ListaKnjiga.Count; i++)
            {
                if (naziv == Data.ListaKnjiga[i].Naziv)
                {
                    indeksPronadjeneKnjige = int.Parse(Data.ListaKnjiga[i].ID);
                    lblPronadjenaKnjiga.Text = Data.ListaKnjiga[i].ID + " " + naziv;
                    
                }
            }

        }
    }
}
