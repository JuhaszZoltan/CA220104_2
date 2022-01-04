using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220104_2
{
    internal class Program
    {
        static List<Keres> keresek = new List<Keres>();
        static void Main()
        {
            Feladat04();
            Feladat05();
            Feladat06();
            Feladat08();
            Feladat09();
            Console.ReadLine();
        }

        private static void Feladat04()
        {
            using (var sr = new StreamReader(@"..\..\res\NASAlog.txt"))
            {
                while (!sr.EndOfStream)
                {
                    keresek.Add(new Keres(sr.ReadLine()));
                }
            }
        }
        private static void Feladat05()
        {
            Console.WriteLine($"5. feladat: Kérések száma: {keresek.Count}");
        }
        private static void Feladat06()
        {
            int sum = keresek.Sum(x => x.ByteMeret);
            Console.WriteLine($"6. feladat: Válaszok összmérete: {sum} byte");
        }
        private static void Feladat08()
        {
            int db = keresek.Count(x => x.Domain);
            Console.WriteLine(
                "8. feladat: Domain-es kérések: " +
                "{0:0.00}%", db / (float)keresek.Count * 100);
        }
        private static void Feladat09()
        {
            Console.WriteLine("9. feladat: Statisztika:");
            var bg = keresek
                .GroupBy(x => x.HttpKod)
                .ToDictionary(x => x.Key, x => x.Count());
            foreach (var kvp in bg)
            {
                Console.WriteLine($"\t{kvp.Key}: {kvp.Value} db");
            }
        }
    }
}
