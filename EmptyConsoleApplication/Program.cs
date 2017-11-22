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

            string fullname = "UMUT YAMAN";
            string experience = "8 AY";
            string department = "UYGULAMA DESTEK / Ticari Krediler Ürün Geliştirme";
            string programmingLanguages = "PL/SQL , COBOL";
            string expactation = "C# KULLANABİLECEĞİMİ DÜŞÜNEREK AYRILMAK :)";


            Console.WriteLine("İsim     : " + fullname);
            Console.WriteLine("Deneyim  : " + experience);
            Console.WriteLine("Bölüm    : " + department);
            Console.WriteLine("Diller   : " + programmingLanguages);
            Console.WriteLine("Beklenti : " + expactation);

            Console.ReadLine();
        
        
        }
    }
}
