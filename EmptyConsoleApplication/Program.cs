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
            string fullname = ("Gül Bulut");
            short experience = 2;
            string department = ("Süreç ve Ölçme");
            string programminglanguages = ("C");
            string expectation = ("Herkes bu işi yapabileceğini düşünerek ayrılsın");
            Console.WriteLine("İsim : " + fullname);
            Console.WriteLine("Tecrübe : " + experience );
            Console.WriteLine("Bölüm : " + department);
            Console.WriteLine("Diller : " + programminglanguages);
            Console.WriteLine("Beklenti : " + expectation);
            Console.ReadLine();
            
        }
    }
}
