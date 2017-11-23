using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{

    class Interest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount : ");
            string samount = Console.ReadLine();
            decimal amount = Convert.ToDecimal(samount);

            Console.WriteLine("Year : ");
            string syear = Console.ReadLine();
            int year = Convert.ToInt16(syear);

            Console.WriteLine("Interest Rate : ");
            string sinterestRate = Console.ReadLine();
            decimal interestRate = Convert.ToDecimal(sinterestRate);

            decimal result = amount * year * interestRate / 100;
            Console.WriteLine("The result is : " + result);
            Console.ReadLine();

        }

    }

}



