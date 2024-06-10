using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace biblioteka
{
    internal interface IPolica
    {
        void Dodavanje(string ID, string oznaka, string prostorija, List<Napomena> napomena);
        void IspravljanjePodataka(int ID);
        void PromenaStatusa();
    }
}