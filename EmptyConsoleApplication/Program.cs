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
            string fullName = "Emre KALYON";
            short experience = 10;
            string programmingLanguages = ".net, cobol";
            string expectations = ".NET yazabileceğimi düşünerek ayrılmak";
            string department = "Resmi ve Özel Ödemeler Müdürlüğü";
            Console.WriteLine("İsim: " + fullName);
            Console.WriteLine("Tecrübe: " + experience);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Kullandığı Diller: " + programmingLanguages);
            Console.WriteLine("Bekletiler: " + expectations);
            Console.ReadLine();
        }
    }
}
