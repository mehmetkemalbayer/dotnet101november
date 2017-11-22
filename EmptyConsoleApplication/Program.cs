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


            string fullName = "Öykü BİLEN";
            short experience = 8;
            string department = "Uygulama Destek";
            string programmingLanguages = "ASP.NET MVC,C#,C,MATLAB,JAVA";
            string expectation = "Maximum  ";

            Console.WriteLine("İsim :" + fullName);
            Console.WriteLine("Deneyim :" + experience + "ay");
            Console.WriteLine("Programlama dilleri :" + programmingLanguages);
            Console.WriteLine("Beklenti :" + expectation);

           
            Console.ReadLine();

          
        }
        
    }
}
