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
            string fullName  = "Gözde Oğuz";
            short experience = 2;
            string department = "Taksitli Krediler ve Ek Hesap Uygulamaları";
            string programmingLanguage = " .net, cobol";
            string expectation = "sadece kodlamayı değil nasıl kullanacağımı öğrenmek";
            Console.WriteLine( "İsim :" + fullName);
            Console.WriteLine( "Tecrübe :" + experience);
            Console.WriteLine( "Bölüm :" + department);
            Console.WriteLine( "Prog. Dilleri :" + programmingLanguage);
            Console.WriteLine( "Beklenti :" + expectation);
            Console.ReadLine();
        }
    }
}
