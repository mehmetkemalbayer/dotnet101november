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
            string fullName = "Meltem Elmas";
            short experience = 8 ;
            string department = "Uygulama Destek";
            string programingLanguage = "C";
            string experation = "yeni bilgi";
            Console.WriteLine("isim:"+fullName);
            Console.WriteLine("tecrübe:"+experience+"ay");
            Console.WriteLine("bölüm:"+department);
            Console.WriteLine("diller:"+programingLanguage);
            Console.WriteLine("beklenti:"+experation);
            Console.ReadLine();
        }
    }
}
