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

            //User firstUser = new User(5);
            //firstUser.WriteInfo();
            User secondUser = new User();
            secondUser.WriteInfo();
          
            Console.ReadLine();
        }

       

        
    }
}
