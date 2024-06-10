using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal interface ICitalac : IOsoba
    {
        bool ProveraJMBG();
        void UzimanjeKnjige(string naslovKnjige, string autor, DateTime datumUzimanja, string bibliotekar, DateTime rokVracanja);
        void VracanjeKnjige(string naslovKnjige);
        void IspravljanjePodataka(string status, string ime, string prezime, string imeJednogRoditelja, string pol,
                                  int danRodjenja, int mesecRodjenja, int godinaRodjenja, string jmbg, string adresaUlicaBr,
                                  string adresaGrad, int adresaPostanskiBr, string telefon, string mail, string stepenStrucneSpreme,
                                  string skolskoZvanje, string trenutniRadniStatus, string brojIDDokumenta, string brojClanskeKarte,
                                  DateTime prviUpis, DateTime produzenjeClanstva, float iznosClanarine, DateTime trajanjeClanstva,
                                  List<Tuple<string, string, DateTime, DateTime, string, bool>> listaSvihKnjiga,
                                  List<Tuple<string, string, DateTime, DateTime, string>> listaTrenutnoUzetihKnjiga, List<string> napomena);
        new void PromenaStatusa();
    }
}