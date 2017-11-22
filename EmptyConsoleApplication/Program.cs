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
            string FullName = "Gizem Balıktutan"; /**/
            short Experience = 2;
            string Department = "POS Uygulamaları";
            string ProgrammingLanguage = "PL/SQL, C++";
            string Expectation = "Başarı";

            Console.WriteLine("İsim = " + FullName);
            Console.WriteLine("Birim = " + Department);
            Console.WriteLine("Deneyim = " + Experience + " yıl");
            Console.WriteLine("Programlama Dilleri = " + ProgrammingLanguage);
            Console.WriteLine("Beklenti = " + Expectation);
            Console.ReadLine(); /*bu komut siyah ekranı bekletir.*/
        }
    }
}
