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
            string fullname = "CeyhunTasdemir";
            string experience = "6ay";
            string department = "Uygulama Destek";
            string Languge = "Cobol";
            string expectation = "C# mantığını kavramak";
            Console.WriteLine("isim:"+ fullname);
            Console.WriteLine("tecrübe:"+ experience);
            Console.WriteLine("bölüm:"+ department);
            Console.WriteLine("dil:"+Languge );
            Console.WriteLine("beklenti:"+ expectation);
            Console.Read();

        }

    }
}
