using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace biblioteka
{
    public class Osoba : Covek, IOsoba
    {
        
        public string ImeJednogRoditelja;
        public int DanRodjenja;
        public int MesecRodjenja;
        public string JMBG;
        public string AdresaUlicaBr;
        public string AdresaGrad;
        public int AdresaPostanskiBr;
        public string Telefon;
        public string Mail;

        string stepenstrucnespreme;
        public string StepenStrucneSpreme
        {
            get
            {
                return stepenstrucnespreme;
            }
            set
            {
                if (value == "I" || value == "II" || value == "III" || value == "IV" || value == "V" || value == "VI" || value == "VII" || value == "VIII" )
                {
                    stepenstrucnespreme = value;
                }
            }
        }

        public string SkolskoZvanje;

        public Osoba(string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena, string imejednogroditelja, int danrodjenja, int mesecrodjenja, string jmbg, string adresaulicabr, string adresagrad, int adresapostanskibr, string telefon, string mail, string stepenstrucnespreme, string skolskozvanje)
            :base (id, status, ime, prezime, pol, godinarodjenja, napomena)
        {
            this.ImeJednogRoditelja = imejednogroditelja;
            this.DanRodjenja = danrodjenja;
            this.MesecRodjenja = mesecrodjenja;
            this.JMBG = jmbg;
            this.AdresaUlicaBr = adresaulicabr;
            this.AdresaGrad = adresagrad;
            this.AdresaPostanskiBr = adresapostanskibr;
            this.Telefon = telefon;
            this.Mail = mail;
            this.StepenStrucneSpreme = stepenstrucnespreme;
            this.SkolskoZvanje = skolskozvanje;
        }
        public Osoba()
        {

        }

        public bool JMBGProvera()
        {
            if (JMBG.Length < 7)
            {
                return false; 
            }

            string danMesecGodina = DanRodjenja.ToString("D2") + MesecRodjenja.ToString("D2") + GodinaRodjenja.ToString("D3");
            string prvihSedamCifara = JMBG.Substring(0, 7);

            return danMesecGodina == prvihSedamCifara;
        }
        public void UzimanjeKnjige()
        {
        
        }
        public void VracanjeKnjige()
        {

        }
    }
}