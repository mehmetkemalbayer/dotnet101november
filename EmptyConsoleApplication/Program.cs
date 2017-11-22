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
            String name = "nilüfer";
            int experience = 12;
            String department = "mimari yönetim";
            String expectation = "huzur";

            Console.WriteLine("isim : " + name);
            Console.WriteLine("tecrübe : " + experience);
            Console.WriteLine("bölüm : " + department);
            Console.WriteLine("beklenti : " + expectation);
            Console.Read();
        }
    }
}
