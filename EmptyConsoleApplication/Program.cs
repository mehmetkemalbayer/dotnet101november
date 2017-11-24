using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{

    class Program
    {
        static int minDeger = 0;
        static int maxDeger = 100;
        static int tahmin = 50;
        static string durum = "r";
        static void Main(string[] args)
        {

            
            while (durum != "d")
            {

                Console.WriteLine("tuttuğun sayı " + tahmin + " mi ?");
                durum = Console.ReadLine();
                try
                {
                    ValidateInput();
                    HandleLessThanCase();
                    HandleGreaterThanCase();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
                    
                
                
                




            }
        }

        private static void HandleGreaterThanCase()
        {
            if (durum == "b" || durum == "B")
            {
                minDeger = tahmin;
                tahmin = minDeger + (maxDeger - minDeger) / 2;
            }
        }

        private static void HandleLessThanCase()
        {
            if (durum == "k" || durum == "K")
            {
                maxDeger = tahmin;
                tahmin = minDeger + (maxDeger - minDeger) / 2;

            }
        }

        static public void ValidateInput()
        {
            if (durum != "k") throw new Exception("Sadece B, K, b ve k girebilirsiniz");
            if (durum != "K") throw new Exception("Sadece B, K, b ve k girebilirsiniz");
            if (durum != "b") throw new Exception("Sadece B, K, b ve k girebilirsiniz");
            if (durum != "B") throw new Exception("Sadece B, K, b ve k girebilirsiniz");            
        }
    }

}

