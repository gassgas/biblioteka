using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal class Bibliotekar : Osoba, IBibliotekar
    {
        public string RadnaPozicija;
        public DateTime DatumZaposlenja;
        public string KorisnickoIme;
        public string Lozinka;
        public List<string> SveIzdateKnjige = new List<string>();
        public List<string> SvePrimljeneKnjige = new List<string>();
        public static int id = 1;  //ovo je samo za pracenje id za svakog bibliotekara, rucno se povecava svaki put kada se doda novi bibliotekar
        public static List<Bibliotekar> bibliotekari = new List<Bibliotekar>();

        public Bibliotekar(string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena, string imejednogroditelja, int danrodjenja, int mesecrodjenja, string jmbg, string adresaulicabr, string adresagrad, int adresapostanskibr, string telefon, string mail, string stepenstrucnespreme, string skolskozvanje, string RadnaPozicija, DateTime datumzaposlenja, string korisnickoime, string lozinka, List<string> sveizdateknjige, List<string> sveprimljeneknjige)
            : base(id, status, ime, prezime, pol, godinarodjenja, napomena, imejednogroditelja, danrodjenja, mesecrodjenja, jmbg, adresaulicabr, adresagrad, adresapostanskibr, telefon, mail, stepenstrucnespreme, skolskozvanje)
        {
            this.RadnaPozicija = RadnaPozicija;
            this.DatumZaposlenja = datumzaposlenja;
            this.KorisnickoIme = korisnickoime;
            this.Lozinka = lozinka;
            this.SveIzdateKnjige = sveizdateknjige;
            this.SvePrimljeneKnjige = sveprimljeneknjige;
            
        }
        public Bibliotekar()
        {

        }
    }
}