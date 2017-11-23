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
            /*string fullName = "Serdar Uz";
            short experience = 11;
            string department = "Süreç ve Ölçme";
            string programmingLanguages = "excel vba, rexx, jcl";
            string expectation = "C# esaslarını öğrenerek iş için bir temel oluşturmak";
            Console.WriteLine("İsim: " + fullName);
            Console.WriteLine("Deneyim " + experience);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Diller: " + programmingLanguages);
            Console.WriteLine("Beklenti: " + expectation);
            Console.WriteLine("Beklenti: @'aaa'" + expectation);
            Console.ReadLine();*/

            // Faiz tutarı hesaplaması
            try {
                Console.WriteLine("Tutar giriniz: ");
                string input = Console.ReadLine();
                //Console.WriteLine(input + " girdiniz.");
                //Console.ReadLine();
                decimal dec = 0;
                dec = Convert.ToDecimal(input);
            
            //Console.WriteLine(dec + " decimal.");
            Console.WriteLine("Faiz oranı giriniz: ");
            decimal faiz = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Yıl: ");
            decimal yil = Convert.ToDecimal(Console.ReadLine());
            decimal faizdahiltutar = dec + yil * dec * faiz / 100;
            Console.WriteLine("%" + faiz + " faizle " + yil + " yıllık tutar: " + faizdahiltutar);
            Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
