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
            //int sum = 0;
            //for (int i = 0; i < 1001; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //string input = Console.ReadLine();
            //Console.WriteLine(input + "girdiniz.");

            Console.WriteLine("Tutar Giriniz.");
            string stutar = Console.ReadLine();
            decimal tutar = Convert.ToDecimal(stutar);
            Console.WriteLine("Yıl Giriniz.");
            string syil = Console.ReadLine();
            int yil = Convert.ToInt16(syil);
            Console.WriteLine("Faiz Oranı Giriniz.");
            string sfaiz = Console.ReadLine();
            decimal faiz = Convert.ToDecimal(sfaiz);
            decimal sonuc = faiz * yil * tutar / 100;
            Console.WriteLine("Sonuç: " + sonuc);
            Console.ReadLine();
        }

       

        
    }
}
