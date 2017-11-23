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
            Console.WriteLine("tutarı giriniz");
            string tutar = Console.ReadLine();
            Console.WriteLine("yılı giriniz");
            string yil = Console.ReadLine();
            Console.WriteLine("faizi giriniz");
            string faiz = Console.ReadLine();
            decimal tutar1 = Convert.ToDecimal(tutar);
            decimal yil1 = Convert.ToDecimal(yil);
            decimal faiz1 = Convert.ToDecimal(faiz);

            decimal faiz_getirisi = tutar1 * (faiz1 / 100) * yil1;

            Console.WriteLine("faiz getirisi" + faiz_getirisi);
            Console.ReadLine();
                       
            




        }


    }


}

