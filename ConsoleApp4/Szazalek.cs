using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp4
{
    class Szazalek
    {
        public double szazzalek(double pont_maximum, int letszam)
        {
            double szazalek = 0;
            //A program létrehozz egy txt fájlt is a mappában.
            StreamWriter iro = new StreamWriter("eredmenyek.txt", true, Encoding.UTF8);
            for (int i = 1; i < letszam; i++)
            {
                Console.Write("Írja be az elért pontszámot: ");
                double pontszam = double.Parse(Console.ReadLine());
                double oszto = pont_maximum / 100;
                szazalek = pontszam / oszto;
                Console.WriteLine(szazalek);
                if (szazalek <= 30)
                {
                    Console.WriteLine("Elégtelen");
                    iro.WriteLine("Az " + i + ". Tanuló pontszáma: " + szazalek);
                    iro.WriteLine("Az " + i + ". Tanuló nem ment át a vizsgán.");
                    iro.WriteLine("\n");
                }
                else if (szazalek <= 40)
                {
                    Console.WriteLine("Elégséges");
                    iro.WriteLine("Az " + i + ". Tanuló pontszáma: " + szazalek);
                    iro.WriteLine("Az " + i + ". Tanuló át ment a vizsgán.");
                    iro.WriteLine("\n");
                }
                else if (szazalek <= 60)
                {
                    Console.WriteLine("Közepes");
                    iro.WriteLine("Az " + i + ". Tanuló pontszáma: " + szazalek);
                    iro.WriteLine("Az " + i + ". Tanuló át ment a vizsgán.");
                    iro.WriteLine("\n");
                }
                else if (szazalek <= 79)
                {
                    Console.WriteLine("Jó");
                    iro.WriteLine("Az " + i + ". Tanuló pontszáma: " + szazalek);
                    iro.WriteLine("Az " + i + ". Tanuló át ment a vizsgán.");
                    iro.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Kiváló");
                    iro.WriteLine("Az " + i + ". Tanuló pontszáma: " + szazalek);
                    iro.WriteLine("Az " + i + ". Tanuló át ment a vizsgán.");
                    iro.WriteLine("\n");
                }
            }
            iro.Flush();
            iro.Close();
            return szazalek;
        }
    }
}
