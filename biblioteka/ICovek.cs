using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    public interface ICovek
    {
        void Dodavanje(string ID, string status, string ime, string prezime, string pol, int godina_rodjenja, List<Napomena> napomena);
        void IspravljanjePodataka(int ID);
        void PromenaStatusa();
    }
}