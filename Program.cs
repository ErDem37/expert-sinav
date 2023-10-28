using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen yazılı puanını giriniz");
                string yazili = Console.ReadLine();
                Console.WriteLine("Lütfen dinleme puanını giriniz");
                string dinleme = Console.ReadLine();
                Console.WriteLine("Lütfen konuşma puanını giriniz");
                string konuşma = Console.ReadLine();
                yazilinot not = new yazilinot();
                bool x = yazilinot.Yazilinot1(yazili, dinleme, konuşma);
                if (x==false)
                {
                    continue;
                }
                int konusma = Convert.ToInt32(konuşma);
                int dinleme1 = Convert.ToInt32(dinleme);
                int yazılı = Convert.ToInt32(yazili);
                if (yazılı > 100)
                {
                    Console.WriteLine("Yazılı değeri 100'den büyük olamaz.");
                    continue;
                }
                if (konusma > 100)
                {
                    Console.WriteLine("Dinleme puanı 100'den büyük olamaz");
                    continue;
                }
                if (dinleme1 > 100)
                {
                    Console.WriteLine("Dinleme puanı 100'den büyük olamaz");
                    continue;
                }
                int yazili1 = ((yazılı * 50) / 100);
                int dinleme2 = ((dinleme1 * 25) / 100);
                int konusma1 = ((konusma * 25) / 100);
                Console.WriteLine("Sınav notu=" + (yazili1 + dinleme2 + konusma1));
                Console.WriteLine("******************************");
            }
        }
    }
}
