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
            string fullName = "Seren Hacaloğlu";
            short experience = 6;
            string department = "Sermaye Piyasaları Uygulamaları";
            string programmingLanguage = "Cobol, C#";
            string expectation = "Herkes bu işi yapabileceğini düşünerek ayrılsın.";
            Console.WriteLine("İsim: " + fullName);
            Console.WriteLine("Tecrübe: " + experience);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Diller: " + programmingLanguage);
            Console.WriteLine("Beklenti: " + expectation);
            Console.ReadLine();
//            System.Threading.Thread.Sleep(10000);
        }
    }
}
