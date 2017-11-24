using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahminpc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int min = 0, max = 100, tahmin, sayac = 1;
                char cevap;
                Random rnd = new Random();
                while (true)
                {
                    Console.Clear();
                    tahmin = rnd.Next((min + 1), max);
                    //if (sayac == 1)
                    //    tahmin = 50;
                    Console.WriteLine("Tahminim  " + tahmin);
                    Console.WriteLine("Tahminim Aklındaki Sayıdan Büyükse (b)");
                    Console.WriteLine("Tahminim Aklındaki Sayıdan Küçükse (k)");
                    Console.WriteLine("Tahminim Doğruysa (e)");

                    while (true)
                    {
                        cevap = Console.ReadKey().KeyChar;
                        if (cevap == 'e' || cevap == 'b' || cevap == 'k')
                        {
                            break;//ahmetcansever.com
                        }
                        Console.WriteLine("  Lütfen yönlendirmeyi yapın düzgün yapın!");
                    }

                    if (cevap == 'e')
                    {
                        break;
                    }
                    else if (cevap == 'b')
                    {//ahmetcansever.com
                        max = tahmin;
                    }
                    else if (cevap == 'k')
                    {
                        min = tahmin;
                    }
                    sayac++;
                }
                Console.WriteLine();
                Console.WriteLine("Sonucu buldum. Tuttuğun Sayı : " + tahmin);
                Console.WriteLine("Tahmin Sayısı : " + sayac);
            }
            catch
            {//ahmetcansever.com
                Console.WriteLine("Yanlış Yönlendirme Yaptınız!!!");
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}