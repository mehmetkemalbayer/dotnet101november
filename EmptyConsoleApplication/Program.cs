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
            double toplam = 0;
            Console.WriteLine("1'den büyük bir sayı giriniz");
            int sayi = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1den " + sayi + "'e kadar toplam = " + toplam);
            Console.Read();
        }
    }
}
