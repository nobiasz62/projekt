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

            // Fájl beolvasása
            using (StreamReader sr = new StreamReader(beolvas))
            {
                while (!sr.EndOfStream) // Amíg nem érünk a fájl végére
                {
                    string[] adatok = sr.ReadLine().Split(';'); // Egy sor beolvasása a fájlból és az adatok szétválasztása

                    // Ellenőrizzük, hogy a sor 6 elemet tartalmaz-e és konvertálhatóak-e a megfelelő típusokra
                    if (adatok.Length == 6 &&
                        int.TryParse(adatok[0], out int helyezes) &&
                        double.TryParse(adatok[1], out double eredmeny) &&
                        DateTime.TryParse(adatok[5], out DateTime datum)) // Ez a blokk akkor fut le, ha mindhárom feltétel igaz.
                    {
                        sportolok.Add(new Sportolo(helyezes, eredmeny, adatok[2], adatok[3], adatok[4], datum)); // Új Sportolo objektum létrehozása és hozzáadása a listához
                    }
                }
            }

            // d. Statisztika készítése
            double atlag = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            double osszeg = 0;

            foreach (var sportolo in sportolok)
            {
                osszeg += sportolo.Eredmeny;
                if (sportolo.Eredmeny > max) max = sportolo.Eredmeny;
                if (sportolo.Eredmeny < min) min = sportolo.Eredmeny;
            }
            atlag = osszeg / sportolok.Count;

            Console.WriteLine($"Átlag: {atlag}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Összeg: {osszeg}");

            // e. Szűrés és kiírás
            Console.WriteLine("Adjon meg egy minimális eredményt:");
            double minEredmeny = double.Parse(Console.ReadLine());

            StreamWriter sw = new StreamWriter("szurt_eredmenyek.txt");

            foreach (var sportolo in sportolok)
            {
                if (sportolo.Eredmeny >= minEredmeny)
                {
                    string kimenet = $"{sportolo.Nev} - {sportolo.Eredmeny}";
                    Console.WriteLine(kimenet);
                    sw.WriteLine(kimenet);
                }
            }

            sw.Close();

            Console.WriteLine("\nENTER-re leáll");
            Console.ReadLine();
        }
    }
}
