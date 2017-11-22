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
            string fullName = "Mehmet Kemal Bayer";
            short experience = 10;
            string department = "Inovasyon";
            string programmingLanguages = ".net, cobol, node.js";
            string expectation = "Herkes bu işi yapabileceğini düşünerek ayrılsın.";
            Console.WriteLine("İsim: " + fullName);
            Console.WriteLine("Tecrübe: " + experience);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Diller: " + programmingLanguages);
            Console.WriteLine("Beklenti: " + expectation);
            Console.ReadLine();
        }
    }
}
