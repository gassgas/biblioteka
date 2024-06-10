using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal interface IKnjiga
    {
        void UzimanjeKnjige();
        void VracanjeKnjige();
        void Dodavanje(string ID, string status, string naziv, List<string> pisac, string zanr, int redni_broj_izdanja, int godina_izdavanja, string izdavac, string ISBN, string stanje, string prostorija, string polica, int broj_primeraka, List<string> sva_izdanja, string citalac, DateTime datum_izdavanja, DateTime rok, string bibliotekar, List<Napomena> napomena);
        void IspravljanjePodataka(int ID);
        void PromenaStatusa();
        void AzuriranjePisca(int ID);
    }
}