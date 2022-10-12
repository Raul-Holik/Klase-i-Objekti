using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //instanciranje objekta
         Osoba osoba = new Osoba();

            //pozivanje set metoda
            osoba.setIme("Pero");
            osoba.setprezime("Perić");
            osoba.setgodRodjenja(2005);
            osoba.settezina(70);
            osoba.setvisina(176);
            osoba.setspol('M');

            //pozivanje get metoda i ispis
            Console.WriteLine("Osoba 1: ");
            Console.WriteLine("Ime i prezime :" + osoba.GetIme() + " "+ osoba.GetPrezime() + "\r\n Godina rodjenja: " + osoba.GetgodRodjenja() +
             " \r\n Visina : "+ osoba.GetVisina() + "\r\n Tezina: " + osoba.GetTezina() + "\r\n Spol : "+ osoba.GetSpol());
            //instanciranje objekata 2

            Osoba osoba2 = new Osoba("Ana", "Anić", 2001, 164, 66, 'Ž');
            Console.WriteLine("Osoba 2");
            Console.WriteLine(osoba2.Ispis());

            Console.WriteLine("\r\nOsoba2 - override ");
            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();
        }
    }
    class Osoba
    {
        //svojstava
        string ime, prezime;
        int godRodjenja, visina, tezina;
        char spol;

        //metode

        //set metode
        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public void setprezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void setgodRodjenja(int godRodjenja)
        {
            this.godRodjenja = godRodjenja;
        }
        public void setvisina(int visina)
        {
            this.visina = visina;
        }
        public void settezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void setspol(char spol)
        {
            this.spol = spol;
        }

        //get metode
        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetgodRodjenja()
        {
            return this.godRodjenja;
        }
        public int GetVisina()
        {
            return this.visina;
        }
        public int GetTezina()
        {
            return this.tezina;
        }
        public char GetSpol()
        {
            return this.spol;
        }

        public string Ispis()
        {
            string ispis = "Ime i prezime :" + this.GetIme() + " " + this.GetPrezime() + "\r\n Godina rodjenja: " + this.GetgodRodjenja() +
            " \r\n Visina : " + this.GetVisina() + "\r\n Tezina: " + this.GetTezina() + "\r\n Spol : " + this.GetSpol();
            return ispis;
        }

        public override string ToString()
        {
            string ispis = "Ime i prezime :" + this.GetIme() + " " + this.GetPrezime() + "\r\n Godina rodjenja: " + this.GetgodRodjenja() +
            " \r\n Visina : " + this.GetVisina() + "\r\n Tezina: " + this.GetTezina() + "\r\n Spol : " + this.GetSpol();
            return ispis;
        }
        
    //konstruktor
    public Osoba()
        {

        }

        public Osoba(string ime, string prezime, int godRodjenja, int tezina, int visina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodjenja = godRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol=spol;
        }
    }
}
