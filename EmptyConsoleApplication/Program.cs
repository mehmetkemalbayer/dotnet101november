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
			int total = 0;
			for (int i = 0; i <= 1000; i++)
			{
				total = total + i;
				Console.WriteLine(total);
			}
			Console.WriteLine("Toplam: " + total);
			Console.ReadLine();

		}


	}


	



}


