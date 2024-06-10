using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{

    public class Citalac : Osoba, ICitalac
    {
        public string TrenutniRadniStatus { get; set; }
        public string BrojIDDokumenta { get; set; }
        public string BrojClanskeKarte { get; set; }
        public DateTime PrviUpis { get; set; }
        public DateTime ProduzenjeClanstva { get; set; }
        public float IznosClanarine { get; set; }
        public DateTime TrajanjeClanstva { get; set; }
        public List<Tuple<string, string, DateTime, DateTime, string, bool>> ListaSvihKnjiga { get; set; }
        public List<Tuple<string, string, DateTime, DateTime, string>> ListaTrenutnoUzetihKnjiga { get; set; }

        public Citalac(string id, string status, string ime, string prezime, string imeJednogRoditelja, string pol,
                       int danRodjenja, int mesecRodjenja, int godinaRodjenja, string jmbg, string adresaUlicaBr,
                       string adresaGrad, int adresaPostanskiBr, string telefon, string mail, string stepenStrucneSpreme,
                       string skolskoZvanje, string trenutniRadniStatus, string brojIDDokumenta, string brojClanskeKarte,
                       DateTime prviUpis, DateTime produzenjeClanstva, float iznosClanarine, DateTime trajanjeClanstva,
                       List<Tuple<string, string, DateTime, DateTime, string, bool>> listaSvihKnjiga,
                       List<Tuple<string, string, DateTime, DateTime, string>> listaTrenutnoUzetihKnjiga, List<string> napomena)
            : base(id, status, ime, prezime, pol, godinaRodjenja, napomena, imeJednogRoditelja, danRodjenja,
                   mesecRodjenja, jmbg, adresaUlicaBr, adresaGrad, adresaPostanskiBr, telefon, mail, stepenStrucneSpreme, skolskoZvanje)
        {
            this.TrenutniRadniStatus = trenutniRadniStatus;
            this.BrojIDDokumenta = brojIDDokumenta;
            this.BrojClanskeKarte = brojClanskeKarte;
            this.PrviUpis = prviUpis;
            this.ProduzenjeClanstva = produzenjeClanstva;
            this.IznosClanarine = iznosClanarine;
            this.TrajanjeClanstva = trajanjeClanstva;
            this.ListaSvihKnjiga = listaSvihKnjiga;
            this.ListaTrenutnoUzetihKnjiga = listaTrenutnoUzetihKnjiga;
        }

        public Citalac() : base()
        {
            this.ListaSvihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string, bool>>();
            this.ListaTrenutnoUzetihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string>>();
        }


        public bool ProveraJMBG()
        {
            if (JMBG.Length < 7)
            {
                return false;
            }

            string danMesecGodina = DanRodjenja.ToString("D2") + MesecRodjenja.ToString("D2") + GodinaRodjenja.ToString("D3");
            string prvihSedamCifara = JMBG.Substring(0, 7);

            return danMesecGodina == prvihSedamCifara;
        }


        public void UzimanjeKnjige(string naslovKnjige, string autor, DateTime datumUzimanja, string bibliotekar, DateTime rokVracanja)
        {
            this.ListaTrenutnoUzetihKnjiga.Add(new Tuple<string, string, DateTime, DateTime, string>(naslovKnjige, autor, datumUzimanja, rokVracanja, bibliotekar));
        }


        public void VracanjeKnjige(string naslovKnjige)
        {
            var knjiga = this.ListaTrenutnoUzetihKnjiga.FirstOrDefault(k => k.Item1 == naslovKnjige);
            if (knjiga != null)
            {
                this.ListaTrenutnoUzetihKnjiga.Remove(knjiga);
                bool prekoracenjeRoka = DateTime.Now > knjiga.Item4;
                this.ListaSvihKnjiga.Add(new Tuple<string, string, DateTime, DateTime, string, bool>(knjiga.Item1, knjiga.Item2, knjiga.Item3, DateTime.Now, knjiga.Item5, prekoracenjeRoka));
            }
        }

    
        public void IspravljanjePodataka(string status, string ime, string prezime, string imeJednogRoditelja, string pol,
                                         int danRodjenja, int mesecRodjenja, int godinaRodjenja, string jmbg, string adresaUlicaBr,
                                         string adresaGrad, int adresaPostanskiBr, string telefon, string mail, string stepenStrucneSpreme,
                                         string skolskoZvanje, string trenutniRadniStatus, string brojIDDokumenta, string brojClanskeKarte,
                                         DateTime prviUpis, DateTime produzenjeClanstva, float iznosClanarine, DateTime trajanjeClanstva,
                                         List<Tuple<string, string, DateTime, DateTime, string, bool>> listaSvihKnjiga,
                                         List<Tuple<string, string, DateTime, DateTime, string>> listaTrenutnoUzetihKnjiga, List<string> napomena)
        {
            if (this.Status == "aktivan")
            {
                this.Status = status;
                this.Ime = ime;
                this.Prezime = prezime;
                this.ImeJednogRoditelja = imeJednogRoditelja;
                this.Pol = pol;
                this.DanRodjenja = danRodjenja;
                this.MesecRodjenja = mesecRodjenja;
                this.GodinaRodjenja = godinaRodjenja;
                this.JMBG = jmbg;
                this.AdresaUlicaBr = adresaUlicaBr;
                this.AdresaGrad = adresaGrad;
                this.AdresaPostanskiBr = adresaPostanskiBr;
                this.Telefon = telefon;
                this.Mail = mail;
                this.StepenStrucneSpreme = stepenStrucneSpreme;
                this.SkolskoZvanje = skolskoZvanje;
                this.TrenutniRadniStatus = trenutniRadniStatus;
                this.BrojIDDokumenta = brojIDDokumenta;
                this.BrojClanskeKarte = brojClanskeKarte;
                this.PrviUpis = prviUpis;
                this.ProduzenjeClanstva = produzenjeClanstva;
                this.IznosClanarine = iznosClanarine;
                this.TrajanjeClanstva = trajanjeClanstva;
                this.ListaSvihKnjiga = listaSvihKnjiga;
                this.ListaTrenutnoUzetihKnjiga = listaTrenutnoUzetihKnjiga;
                this.Napomena = napomena;
            }
        }
        public new void PromenaStatusa()
        {
            if (this.Status == "aktivan")
            {
                this.Status = "neaktivan";
            }
            else
            {
                this.Status = "aktivan";
            }
        }

    }


}
