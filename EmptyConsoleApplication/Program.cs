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

            Console.WriteLine("Tutar Giriniz : ");
            string apara = Console.ReadLine();
            
            Console.WriteLine("Yıl Giriniz : ");
            string ayıl = Console.ReadLine();
                        
            Console.WriteLine("Faiz Giriniz : ");
            string afaiz = Console.ReadLine();

            decimal para = Convert.ToDecimal(apara);
            decimal faiz = Convert.ToDecimal(afaiz);
            int yıl = Convert.ToInt16(ayıl);



            decimal hesaplama = (para * faiz * yıl) / 100;

            Console.WriteLine(para);
            Console.WriteLine(ayıl);
            Console.WriteLine(faiz);
            Console.WriteLine(hesaplama);

            Console.ReadLine();


            




        }
        
    }
}
