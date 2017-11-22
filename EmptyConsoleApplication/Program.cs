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
            string fullName =  "Selcuk ER";
            short experience =  5;
            string department = "Uygulama Destek";
            string programingLanguage = "PLSQL,MicrosoSQL,Oracle";
            string expection =  "Kodlama konusunda iyi bir noktaya gelebilmek";
            Console.WriteLine("İsim" + fullName);
            Console.WriteLine("Tecrübe"+ experience);
            Console.WriteLine("Bölüm"+ department);
            Console.WriteLine("Programlama Dili"+ programingLanguage);
            Console.WriteLine("Beklenti" + expection);
            Console.ReadLine();

    }
    }
}