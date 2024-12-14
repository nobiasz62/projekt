using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    internal class AN_TR_SZR
    {
        static void Main(string[] args)
        {
            string beolvas = "kalapacsvetes.txt";
            List<Sportolo> sportolok = new List<Sportolo>();

            //Fájl beolvasása
            StreamReader sr = new StreamReader(beolvas);
            while (!sr.EndOfStream)
            { 
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                int helyezes = int.Parse(adatok[0]);
                double eredmeny = Convert.ToDouble(adatok[1]);
                string nev = adatok[2];
                string orszagkod = adatok[3];
                string helyszin = adatok[4];
                DateTime datum  = Convert.ToDateTime(adatok[5]);
                Sportolo sportolo = new Sportolo(helyezes, eredmeny, nev, orszagkod, helyszin, datum);
                sportolok.Add(sportolo);
            }
            sr.Close();
        }
    }
}
