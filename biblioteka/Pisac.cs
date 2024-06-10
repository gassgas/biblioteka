using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    public class Pisac : Covek, IPisac
    {
        public List<string> knjige = new List<string>();

        public Pisac()
        {

        }

        public Pisac(string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena)
        {
            this.ID = id;
            this.Status = status;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.GodinaRodjenja = godinarodjenja;
            this.Napomena = napomena;
        }

        public void Dodavanje(string ID, string status, string ime, string prezime, int godina_rodjenja, List<string> knjige, List<Napomena> napomena)
        {

        }

        public void IspravljanjePodataka(int ID)
        {

        }
        public void PromenaStatusa()
        {

        }
    }
}