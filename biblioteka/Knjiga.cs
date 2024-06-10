using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    public class Knjiga : IKnjiga
    {
        public string ID;
        public string Status;
        public string Naziv;
        public List<string> Pisac = new List<string>();
        public string Zanr;
        public int RedniBrojIzdanja;
        public int GodinaIzdavanja;
        public string Izdavac;
        public string ISBN;
        public string Stanje;
        public string Prostorija;
        public string Polica;
        public int UkupanBrojPrimeraka;
        public List<string> SvaIzdavanja = new List<string>();
        public string Citalac;
        public string DatumIzdavanja;
        public string RokZaVracanje;
        public string Bibliotekar;
        public List<string> Napomena = new List<string>();


        public Knjiga()
        {

        }

        public Knjiga(string ID, string status, string naziv, string zanr, int redni_broj_izdanja, int godina_izdavanja, string izdavac, string ISBN, string stanje, string prostorija, string polica, int broj_primeraka, string citalac, string bibliotekar, string datum_izdavanja, string rok, List<string> sva_izdanja, List<string> pisac, List<string> napomena)
        {
            this.ID = ID;
            this.Status = status;
            this.Naziv = naziv;
            this.Pisac = pisac;
            this.Zanr = zanr;
            this.RedniBrojIzdanja = redni_broj_izdanja;
            this.GodinaIzdavanja = godina_izdavanja;
            this.Izdavac = izdavac;
            this.ISBN = ISBN;
            this.Stanje = stanje;
            this.Prostorija = prostorija;
            this.Polica = polica;
            this.UkupanBrojPrimeraka = broj_primeraka;
            this.SvaIzdavanja = sva_izdanja;
            this.Citalac = citalac;
            this.DatumIzdavanja = datum_izdavanja;
            this.RokZaVracanje = rok;
            this.Bibliotekar = bibliotekar;
            this.Napomena = napomena;
        }


        /*ID	String
    Status	String
    Naziv knjige	String
    Pisac	Lista stringova
    Zanr	String
    Redni broj izdanja	Int
    Godina izdavanja	Int
    Izdavac	String
    ISBN broj	String
    Stanje	String
    Prostorija	String
    Polica	String
    Ukupan broj primeraka	Int
    Sva izdavanja	Lista stringovi-datumi
    Citalac	String
    Datum izdavanja	Date
    Rok za vracanje	Date
    Bibliotekar 	String
    Napomena	Lista stringova-datuma*/







        public void UzimanjeKnjige()
        {

        }
        public void VracanjeKnjige()
        {

        }
        public void Dodavanje(string ID, string status, string naziv, List<string> pisac, string zanr, int redni_broj_izdanja, int godina_izdavanja, string izdavac, string ISBN, string stanje, string prostorija, string polica, int broj_primeraka, List<string> sva_izdanja, string citalac, DateTime datum_izdavanja, DateTime rok, string bibliotekar, List<Napomena> napomena)
        {

        }
        public void IspravljanjePodataka(int ID)
        {

        }
        public void PromenaStatusa()
        {

        }
        public void AzuriranjePisca(int ID)
        {

        }
    }
}