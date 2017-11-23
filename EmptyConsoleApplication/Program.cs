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
            for (int i = 1; i < 1000; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1den 1000e kadar toplam = " + toplam);
            Console.Read();
        }
    }
}
