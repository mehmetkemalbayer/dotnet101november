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
			string fullname = "Mehmet Zeki Seyhan";
			string experience = "8 ay";
			string department = "Uygulama Destek - Sermaye + Hazine";
			string expectation = "bu işi yapabileceğimi düşünerek ayrılacağım..."; 
			Console.WriteLine("İsim: " + fullname );
			Console.WriteLine("Deneyim: " + experience);
			Console.WriteLine("Bölüm: " + department);
			Console.WriteLine("Beklenti: " + expectation);
			Console.ReadLine();

        }
    }
}
