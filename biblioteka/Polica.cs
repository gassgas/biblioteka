using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace biblioteka
{
    internal class Polica : IPolica
    {
        //        - unos svih podataka o novoj polici,
        //- ispravku podataka o postojećoj polici,
        //- ukidanje aktivnosti postojeće police ako ona iz nekog razloga više ne koristi za smeštaj
        //knjiga(ceo zapis o polici se nikada ne sme potpuno izbrisati pošto postoje arhivirani
        //podaci o aktivnostima u prethodnom periodu u kojima se pominje njeno postojanje),
        //kako se ona više ne bi pojavljivao u pretragama,
        //- pretragu(„search“) za neku određenu policu,
        //- „pomeranje“ na sledeću ili prethodnu policu u listi.

        string ID;
        string oznaka;
        string p;
        bool L_Aktivan;
        //List<string> nap = new List<string>();

        public Polica(string ID, string LOZNAKA, string PROST)
        {
            this.ID = ID;
            oznaka = LOZNAKA;
            p = PROST;
        }

        public void Dodavanje(string ID, string oznaka, string SobaUBiblioteciGdeSeIzlazuKnjige, List<Napomena> OvaPromenjlivaSeNeKoristiAliMoraDaBudeOvdeJerMiInterfejsTakoKazeAMislimDaNemaPoente){
            if (string.IsNullOrEmpty(ID)) return;
            if (string.IsNullOrEmpty(oznaka)) return;
            if (string.IsNullOrEmpty(SobaUBiblioteciGdeSeIzlazuKnjige)) return;
            MessageBox.Show("Dodaj;");
        }

        public void IspravljanjePodataka(int ID)
        {
            MessageBox.Show("Ova funkcija nema dovoljno podataka da uradi apsolutno bilo sta, da bi mogao da promenim listu treba mi lista, tj. pokazivac na listu kao argument. Takodje nemam informaciju sta treba da budo novi podaci na mestu na koje mi ID pokazuje. Nemam ideju zasto postoji interfejs koji me tera da drzim ovu funkciju, ali postoji tako da cu je napraviti tako da nema nikakvu svrhu, koju nemoze da ima zbog malopre navedenih razloga, ali ce da ispisuje nesto sto mislim da niko nikada nece procitati do kraja");
        }

        public void PromenaStatusa()
        {
            L_Aktivan = !L_Aktivan;
        }

        public override string ToString()
        {
            return $"{ID},{oznaka},{p}";
        }
    }
}