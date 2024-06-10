using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal interface IPisac
    {
        void Dodavanje(string ID, string status, string ime, string prezime, int godina_rodjenja, List<string> knjige, List<Napomena> napomena);
        void IspravljanjePodataka(int ID);
        void PromenaStatusa();
    }
}