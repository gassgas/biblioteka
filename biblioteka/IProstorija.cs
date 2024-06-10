using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal interface IProstorija
    {
        void Dodavanje(string ID, string oznaka, List<string> police, List<Napomena> napomena);
        void IspravljanjePodataka(int ID);
        void PromenaStatusa();
    }
}