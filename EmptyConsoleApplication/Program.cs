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
            string fullName = " Cihan Omur";
            string experience = "5 ay";
            string department = "Resmi ve Özel Kurum Ödm. Uyg.";
            string programmingLanguages = "Cobol, Java";
            string expectetion = "C# la birşeyler yazabilmek";
                Console.WriteLine( "İsim: " + fullName );
                Console.WriteLine("Tecrübe: " + experience);
                Console.WriteLine("Departman: " + department);
                Console.WriteLine("Programlama Dilleri: " + programmingLanguages);
            Console.WriteLine("Beklentiler: " + expectetion);         
                Console.ReadLine();
                           
        }
    }
}
