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
          

            string fullName ="Seda Yaman";
            short  experience= 8;
            string department ="Uygulama Destek Uzman Yardımcısı";
            string programmingLanguage="C#,JAVA,.NET,HTML";
            string experation="Yeni bilgiler ile kendimi geliştirmek";

            Console.WriteLine("İsim:"+fullName);
            Console.WriteLine("Tecrübe:"+experience+"ay");
            Console.WriteLine("Bölüm:"+department);
            Console.WriteLine("Diller:"+programmingLanguage);
            Console.WriteLine("Beklenti:"+experation);
           
            Console.ReadLine();

          

        }
    }
}
