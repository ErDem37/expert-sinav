using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class yazilinot
    {
        public static bool Yazilinot1(string yazili, string konusma, string dinleme)
        {
            for (int i = 0; i < yazili.Length; i++)
            {
                char[] yazili1 = yazili.ToCharArray();
                bool kontrol = char.IsNumber(yazili1[i]);
                if (kontrol == false)
                {
                    Console.WriteLine("Yazılı puanı sadece rakamlardan oluşabilir");
                    return false;
                }
                char[] konusma1 = konusma.ToCharArray();
                bool kontrol1 = char.IsNumber(konusma1[i]);
                if (kontrol1 == false)
                {
                    Console.WriteLine("Konuşma puanı sadece rakamlardan oluşabilir");
                    return false;
                }
                char[] dinleme1 = dinleme.ToCharArray();
                bool kontrol2 = char.IsNumber(dinleme1[i]);
                if (kontrol2 == false)
                {
                    Console.WriteLine("Dinleme puanı sadece rakamlardan oluşabilir");
                    return false;

                }
            }
            return true;

        }

    }
}
