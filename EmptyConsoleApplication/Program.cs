using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} ile {1} arasında bir sayı giriniz", 0, 100);
            TahminOyunu(0, 100);
            Console.ReadLine();

        }
        static void TahminOyunu(int altsinir, int ustsinir)
        {
            Console.WriteLine("Tuttuğunuz sayı {0} mi?", (altsinir + ustsinir) / 2);

            string yonlendirme = Console.ReadLine();

            if (yonlendirme == "B")
            {
                altsinir = (altsinir + ustsinir) / 2;
                TahminOyunu(altsinir, ustsinir);
            }
            else if (yonlendirme == "K")
            {
                ustsinir = (altsinir + ustsinir) / 2;
                TahminOyunu(altsinir, ustsinir);
            }
            else if (yonlendirme == "D")
            {
                Console.WriteLine("benle oynadığınız için teşekkür ederiz");
            }
            else
            {
                Console.WriteLine("Yanlış B, K, D girebülürsüüz");
                TahminOyunu(altsinir, ustsinir);
            }

        }
        
    }
}
