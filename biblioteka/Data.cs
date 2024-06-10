using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biblioteka
{
    internal class Data
    {
        public static string ImeFaJlaGDESECJUPOliCe = "OvdeSeCuvajuDugackeRavneDaskaPricvrscenaHorizontalnoCestoUzZidIliUOrmaricuTakoDaSeNaNjojMoguCuvatiPredmeti.csv";
        public static List<Pisac> ListaPisaca = new List<Pisac>();
        public static List<Knjiga> ListaKnjiga = new List<Knjiga>();
        public static List<Polica> listaPolica = new List<Polica>();
        private static List<Prostorija> prostorGdeSeNalazeProstorije = new List<Prostorija>();
        public static List<Citalac> ListaCitalaca = new List<Citalac>();
        List<Tuple<string, string, DateTime, DateTime, string, bool>> ListaSvihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string, bool>>();
        List<Tuple<string, string, DateTime, DateTime, string>> ListaTrenutnoUzetihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string>>();
        public static string ImeFaJlaGDESECJUprost = "prostor unutar građevine. Najčešće je odvojena zidom i vratima.txt";

        public static void DodajPisca(Pisac p)
        {
            ListaPisaca.Add(p);
        }
        public static void DodajKnjigu(Knjiga k)
        {
            ListaKnjiga.Add(k);
        }



        public static Knjiga pomeranjeKnjige(int g)
        {
            string indeks = g.ToString();
            Knjiga k = new Knjiga();
            for (int i = 0; i < ListaKnjiga.Count; i++)
            {
                if(ListaKnjiga[i].ID == indeks)
                {
                    k = ListaKnjiga[i];
                }
            }
            return k;
        }

        public static Pisac pomeranjePisca(int g)
        {
            string indeks = g.ToString();
            Pisac p = new Pisac();
            for (int i = 0; i < ListaPisaca.Count; i++)
            {
                if(ListaPisaca[i].ID == indeks)
                {
                    p = ListaPisaca[i];
                }
            }
            return p;
        }


        public static void SacuvajKnjige()
        {
            try
            {
                StreamWriter sw = new StreamWriter("knjige.txt");

                for (int i = 0; i < ListaKnjiga.Count; i++)
                {
                    Knjiga k = ListaKnjiga[i];
                    string si = "";
                    string p = "";
                    string n = "";

                    if (k.Napomena.Count > 0)
                    {
                        for (int j = 0; j < k.Napomena.Count - 1; j++)
                        {
                            n += k.Napomena[j] + '$';
                        }
                        n += k.Napomena[k.Napomena.Count - 1];
                    }


                    if (k.Pisac.Count > 0)
                    {
                        for (int j = 0; j < k.Pisac.Count - 1; j++)
                        {
                            p += k.Pisac[j] + '$';
                        }
                        p += k.Pisac[k.Pisac.Count - 1];
                    }


                    if (k.SvaIzdavanja.Count > 0)
                    {
                        for (int j = 0; j < k.SvaIzdavanja.Count - 1; j++)
                        {
                            p = k.SvaIzdavanja[j] + '$';
                        }
                        p = k.SvaIzdavanja[k.SvaIzdavanja.Count - 1];
                    }



                    sw.WriteLine(k.ID + "," +
                        k.Status + "," +
                        k.Naziv + "," +
                        k.Zanr + "," +
                        k.RedniBrojIzdanja + "," +
                        k.GodinaIzdavanja + "," +
                        k.Izdavac + "," +
                        k.ISBN + "," +
                        k.Stanje + "," +
                        k.Prostorija + "," +
                        k.Polica + "," +
                        k.UkupanBrojPrimeraka + "," +
                        k.Citalac + "," +
                        k.Bibliotekar + "," +
                        k.DatumIzdavanja + "," +
                        k.RokZaVracanje + si + "," + p + "," + n);
                }

                sw.Close();
            }
            catch (Exception e) 
            {

            }

        }

        public static void UcitajKnjige()
        {
            try
            {
                StreamReader sr = new StreamReader("knjige.txt", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();

                    List<string> delovi = new List<string>();
                    delovi = l.Split(',').ToList<string>();
                    //string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    List<string> SvaIzdanja = new List<string>();
                    List<string> Pisac = new List<string>();
                    if (delovi.Count >= 7)
                    {
                        napomene = delovi[delovi.Count-1].Split('$').ToList<string>();
                        SvaIzdanja = delovi[delovi.Count - 2].Split('$').ToList<string>();
                        Pisac = delovi[delovi.Count - 3].Split('$').ToList<string>();
                    }

                    //sva izdanja, pisac, napomena;
                    Knjiga k = new Knjiga(delovi[0], delovi[1], delovi[2], delovi[3], int.Parse(delovi[4]), int.Parse(delovi[5]), delovi[6], delovi[7],delovi[8], delovi[9], delovi[10], int.Parse(delovi[11]), delovi[12], delovi[13], delovi[14], delovi[15] ,SvaIzdanja, Pisac,napomene);
                    ListaKnjiga.Add(k);
                }
                sr.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static void UcitajPisce()
        {
            try
            {
                StreamReader sr = new StreamReader("pisci.txt", true);
                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    string[] delovi = l.Split(',');

                    List<string> napomene = new List<string>();
                    if (delovi.Length >= 7)
                    {
                        napomene = delovi[6].Split('$').ToList<string>();
                    }

                    Pisac p = new Pisac(delovi[0], delovi[1], delovi[2], delovi[3], delovi[4], int.Parse(delovi[5]), napomene);
                    ListaPisaca.Add(p);
                    //string id, string status, string ime, string prezime, string pol, int godinarodjenja, List<string> napomena
                }
                sr.Close();
            }
            catch (Exception e)
            {
                
            }
        }

        public static void SacuvajPisce()
        {
            StreamWriter sw = new StreamWriter("pisci.txt");

            for (int i = 0; i < ListaPisaca.Count; i++)
            {
                Pisac p = ListaPisaca[i];
                string n = "";

                if (p.Napomena.Count > 0)
                {
                    for (int j = 0; j < p.Napomena.Count - 1; j++)
                    {
                        n += p.Napomena[j] + '$';
                    }
                    n += p.Napomena[p.Napomena.Count - 1];
                }
                


                sw.WriteLine(p.ID + "," + p.Status + "," + p.Ime + "," + p.Prezime + "," + p.Pol + "," + p.GodinaRodjenja + "," + n);
            }

            sw.Close();
        }

        public static void DodajPolicu(Polica p)
        {
            listaPolica.Add(p);
        }

        public static void SP()
        {
            SacuvajListu(listaPolica, ImeFaJlaGDESECJUPOliCe);
        }

        public static void DP(Prostorija pROStorija)
        {
            prostorGdeSeNalazeProstorije.Add(pROStorija);
        }

        public static void SCUVAj()
        {
            SacuvajListu(prostorGdeSeNalazeProstorije, ImeFaJlaGDESECJUprost);
        }

        public static void SacuvajListu<T>(List<T> listazaCuvanje, string imeFajla){
            StreamWriter upisivac = new StreamWriter(imeFajla);
            for (int i = 0; i < listazaCuvanje.Count; i++)
            {
                upisivac.WriteLine(listazaCuvanje[i].ToString());
            }
            upisivac.Close();
        }

        public void SacuvajUFajlCSV(string filePath)
        {
            try
            {
                
                string csvHeader = "ID,Status,Ime,Prezime,ImeJednogRoditelja,Pol,DanRodjenja,MesecRodjenja,GodinaRodjenja,JMBG,AdresaUlicaBr,AdresaGrad,AdresaPostanskiBr,Telefon,Mail,StepenStrucneSpreme,SkolskoZvanje,TrenutniRadniStatus,BrojIDDokumenta,BrojClanskeKarte,PrviUpis,ProduzenjeClanstva,IznosClanarine,TrajanjeClanstva,ListaSvihKnjiga,ListaTrenutnoUzetihKnjiga,Napomena";

                Citalac pom=new Citalac();
                //string csvData = $"{id},{pom.status},{Ime},{Prezime},{ImeJednogRoditelja},{Pol},{DanRodjenja},{MesecRodjenja},{GodinaRodjenja},{JMBG},{AdresaUlicaBr},{AdresaGrad},{AdresaPostanskiBr},{Telefon},{Mail},{StepenStrucneSpreme},{SkolskoZvanje},{TrenutniRadniStatus},{Citalac.BrojIDDokumenta},{BrojClanskeKarte},{PrviUpis},{ProduzenjeClanstva},{IznosClanarine},{TrajanjeClanstva},{FormatirajListuSvihKnjiga()},{FormatirajListuTrenutnoUzetihKnjiga()},{string.Join(";", Napomena)}";

                // Upisujemo zaglavlje i podatke u CSV fajl
               // File.WriteAllText(filePath, csvHeader + Environment.NewLine + csvData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom čuvanja u fajl: " + ex.Message);
            }
        }

        // Metoda za formatiranje Liste svih knjiga u string
        private string FormatirajListuSvihKnjiga()
        {
            return string.Join("|", ListaSvihKnjiga.Select(k => $"{k.Item1},{k.Item2},{k.Item3},{k.Item4},{k.Item5},{k.Item6}"));
        }

        // Metoda za formatiranje Liste trenutno uzetih knjiga u string
        private string FormatirajListuTrenutnoUzetihKnjiga()
        {
            return string.Join("|", ListaTrenutnoUzetihKnjiga.Select(k => $"{k.Item1},{k.Item2},{k.Item3},{k.Item4},{k.Item5}"));
        }

       /* private void btDodajCitaoca_Click(object sender, EventArgs e)
        {
            FormaDodavanjaCitaoca dodajCitaoca = new FormaDodavanjaCitaoca();
            dodajCitaoca.ShowDialog();
            if (dodajCitaoca.DialogResult == DialogResult.OK)
            {
                List<string> napomene = dodajCitaoca.napomena.Lines.ToList<string>();

                List<Tuple<string, string, DateTime, DateTime, string, bool>> listaSvihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string, bool>>();
                foreach (var knjiga in dodajCitaoca.lstListaSvihKnjiga.Items)
                {
     
                    listaSvihKnjiga.Add((Tuple<string, DateTime, DateTime, DateTime, string, string>)knjiga);
                }

                List<Tuple<string, string, DateTime, DateTime, string>> listaTrenutnoUzetihKnjiga = new List<Tuple<string, string, DateTime, DateTime, string>>();
                foreach (var knjiga in dodajCitaoca.lstListaTrenutnoUzetihKnjiga.Items)
                {
   
                    listaTrenutnoUzetihKnjiga.Add((Tuple<string, DateTime, DateTime, DateTime, string>)knjiga);
                }

                Citalac c = new Citalac(
                    (Data.ListaCitalaca.Count + 1).ToString(),
                    dodajCitaoca.comboBox2.Text,
                    dodajCitaoca.textBox2.Text,
                    dodajCitaoca.textBox3.Text,
                    dodajCitaoca.textBox4.Text,
                    dodajCitaoca.comboBox1.Text,
                    int.Parse(dodajCitaoca.txtGodinaRodjenja.Text),
                    napomene,
                    int.Parse(dodajCitaoca.txtDanRodjenja.Text),
                    int.Parse(dodajCitaoca.txtMesecRodjenja.Text),
                    dodajCitaoca.textBox5.Text,
                    dodajCitaoca.txtAdresaUlicaBr.Text,
                    dodajCitaoca.txtAdresaGrad.Text,
                    int.Parse(dodajCitaoca.txtAdresaPostanskiBr.Text),
                    dodajCitaoca.textBox7.Text,
                    dodajCitaoca.textBox8.Text,
                    dodajCitaoca.textBox9.Text,
                    dodajCitaoca.textBox10.Text,
                    dodajCitaoca.textBox11.Text,
                    dodajCitaoca.textBox12.Text,
                    dodajCitaoca.textBox13.Text,
                    DateTime.Parse(dodajCitaoca.dateTimePicker2.Text),
                    DateTime.Parse(dodajCitaoca.dateTimePicker3.Text),
                    float.Parse(dodajCitaoca.textBox14.Text),
                    DateTime.Parse(dodajCitaoca.textBox15.Text)

                );

                Data.DodajCitaoca(c);
                Data.SacuvajCitaoce(@"C:Users\user\Desktop\Projekat-- - Biblioteka - masper\biblioteka\bin");
                popuniComboBox();

            }
        }*/

            

        public static void DodajCitaoca(Citalac citalac)
        {
            ListaCitalaca.Add(citalac);
        }

        public static void SacuvajCitaoce(string filePath)
        {
            try
            {
                // Definišemo zaglavlje CSV fajla
                string csvHeader = "ID,Status,Ime,Prezime,ImeJednogRoditelja,Pol,DanRodjenja,MesecRodjenja,GodinaRodjenja,JMBG,AdresaUlicaBr,AdresaGrad,AdresaPostanskiBr,Telefon,Mail,StepenStrucneSpreme,SkolskoZvanje,TrenutniRadniStatus,BrojIDDokumenta,BrojClanskeKarte,PrviUpis,ProduzenjeClanstva,IznosClanarine,TrajanjeClanstva,ListaSvihKnjiga,ListaTrenutnoUzetihKnjiga,Napomena";

                // Pripremamo podatke za zapis u CSV format
                List<string> csvData = new List<string>();
                csvData.Add(csvHeader);

                foreach (var citalac in ListaCitalaca)
                {
                   // string csvRow = $"{citalac.ID},{citalac.Status},{citalac.Ime},{citalac.Prezime},{citalac.ImeJednogRoditelja},{citalac.Pol},{citalac.DanRodjenja},{citalac.MesecRodjenja},{citalac.GodinaRodjenja},{citalac.JMBG},{citalac.AdresaUlicaBr},{citalac.AdresaGrad},{citalac.AdresaPostanskiBr},{citalac.Telefon},{citalac.Mail},{citalac.StepenStrucneSpreme},{citalac.SkolskoZvanje},{citalac.TrenutniRadniStatus},{citalac.BrojIDDokumenta},{citalac.BrojClanskeKarte},{citalac.PrviUpis},{citalac.ProduzenjeClanstva},{citalac.IznosClanarine},{citalac.TrajanjeClanstva},{FormatirajListuSvihKnjiga(citalac.ListaSvihKnjiga)},{FormatirajListuTrenutnoUzetihKnjiga(citalac.ListaTrenutnoUzetihKnjiga)},{string.Join(";", citalac.Napomena)}";
                   // csvData.Add(csvRow);
                }

                // Upisujemo podatke u CSV fajl
                File.WriteAllLines(filePath, csvData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom čuvanja u fajl: " + ex.Message);
            }
        }
    }
}
