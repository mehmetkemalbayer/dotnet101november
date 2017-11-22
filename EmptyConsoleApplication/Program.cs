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
            string fullName = "Aynur Bostancı";
            short experience = 8 ;
            string department = "uygulama destek";
            string programinglanguage = "c";
            string experation = "başarı";
            Console.WriteLine("isim:"+fullName);
            Console.WriteLine("tecrübe:"+experience+"ay");
            Console.WriteLine("bölüm:"+department);
            Console.WriteLine("diller:"+programinglanguage);
            Console.WriteLine("beklenti:"+experation);
            Console.ReadLine();
        }
    }
}
