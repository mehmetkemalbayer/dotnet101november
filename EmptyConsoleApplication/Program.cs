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
            Console.WriteLine("0-100 arası bir sayı tutunuz: " );
            string sayi1 = Console.ReadLine();
            int sayi2 = Convert.ToInt32(sayi1);

            if (sayi2 < 50)
            {
                Console.WriteLine("sayı küçük");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("sayı büyük");
                Console.ReadLine();
            }
			

		}


	}


	



}


