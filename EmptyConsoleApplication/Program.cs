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
            string fullName = "Semra Güngör";
            short experience = 7;
            string department = "Ödemeler";
            string languages = "Cobol, C, delphi";
            string expectation =  ".net öğrenmeye nereden başlayacağıma dair aydınlanarak ayrılmak istiyorum";
            Console.WriteLine("isim:" + fullName);
            Console.WriteLine("experience:" + experience);
            Console.WriteLine("department" + department);
            Console.WriteLine("languages:" + languages);
            Console.WriteLine("expectation" + expectation);
            Console.ReadLine();

        }
    }
}
