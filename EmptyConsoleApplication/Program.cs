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

            int toplam = 0;

            for (int i = 0; i < 1000; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);

           



           
            Console.ReadLine();

          
        }

      static  void WriteName (string name)
        {
            Console.WriteLine("İsim :" + name);
          Console.WriteLine();
        }

      static  void WriteExperience(short ay)
        {
            Console.WriteLine("Deneyim :" + ay + "ay");
        }
        
    }

    
}
