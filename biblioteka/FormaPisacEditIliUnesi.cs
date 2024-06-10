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
    public partial class FormaPisacEditIliUnesi : Form
    {
        public int indeksPronadjenogPisca;
        public FormaPisacEditIliUnesi()
        {
            InitializeComponent();
            popuniComboBox();
        }


        void popuniComboBox()
        {
            cbPisci.Items.Clear();
            for (int i = 0; i < Data.ListaPisaca.Count; i++)
            {
                cbPisci.Items.Add(Data.ListaPisaca[i].ID + " " + Data.ListaPisaca[i].Ime + " " + Data.ListaPisaca[i].Prezime);
            }
        }

        private void btDodajPisca_Click(object sender, EventArgs e)
        {
            FormPisac dodajPisca = new FormPisac();
            dodajPisca.ShowDialog();
            dodajPisca.btDesno.Hide();
            dodajPisca.btLevo.Hide();
            if (dodajPisca.DialogResult == DialogResult.OK)
            {
                
                List<string> napomene = new List<string>();

                napomene = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                int g = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                Pisac p = new Pisac((Data.ListaPisaca.Count + 1).ToString(), dodajPisca.cbStatusPisca.Text, dodajPisca.txtImePisca.Text, dodajPisca.txtPrezimePisca.Text, dodajPisca.cbPol.Text, g, napomene);
                Data.DodajPisca(p);
                Data.SacuvajPisce();
                popuniComboBox();
            }
        }

        private void btEditPisca_Click(object sender, EventArgs e)
        {
            int indeks = cbPisci.SelectedIndex + 1;
            if (indeks == 0)
            {
                indeks = indeksPronadjenogPisca;
            }

            if (indeks != 0)
            {
                Pisac p = Data.ListaPisaca[indeks-1];
                FormPisac dodajPisca = new FormPisac(p, indeks);
                dodajPisca.ShowDialog();
                dodajPisca.btDesno.Show();
                dodajPisca.btLevo.Show();



                if (dodajPisca.DialogResult == DialogResult.OK)
                {
                    List<string> napomene = new List<string>();

                    Pisac p2 = Data.pomeranjePisca(dodajPisca.indeks);

                    napomene = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    int g = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p2.Status = dodajPisca.cbStatusPisca.Text;
                    p2.Ime = dodajPisca.txtImePisca.Text;
                    p2.Prezime = dodajPisca.txtPrezimePisca.Text;
                    p2.Pol = dodajPisca.cbPol.Text;
                    p2.GodinaRodjenja = int.Parse(dodajPisca.txtGodinaRodjenjaPisca.Text);
                    p2.Napomena = dodajPisca.txtNapomenePisca.Lines.ToList<string>();

                    Data.SacuvajPisce();
                    popuniComboBox();
                }
            }
        }

        private void cbPisci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPronadjenPisac_Click(object sender, EventArgs e)
        {

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string ime = "";
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
            }

        }
    }
}
