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
            /*String name = "nilüfer";
            int experience = 12;
            String department = "mimari yönetim";
            String expectation = "huzur";
            String diller = "Java, Cobol";

            Console.WriteLine("isim : " + name);
            Console.WriteLine("tecrübe : " + experience);
            Console.WriteLine("bölüm : " + department);
            Console.WriteLine("beklenti : " + expectation);
            Console.WriteLine("diller : " + diller);
            Console.Read();*/

            Console.WriteLine("tutar giriniz");
            string tutatR = Console.ReadLine();
            Console.WriteLine("süre giriniz");
            string sureR = Console.ReadLine();
            Console.WriteLine("oran giriniz");
            string oranR = Console.ReadLine();
            decimal tutar = Convert.ToDecimal(tutatR);
            int sure = Int32.Parse(sureR);
            decimal oran = Convert.ToDecimal(oranR);
            Console.WriteLine("tutar : " + tutar);
            Console.WriteLine("süre  : " + sure);
            Console.WriteLine("oran  : " + oran);
            decimal faiz = tutar * sure * oran / 100;
            Console.WriteLine("faiz  : " + faiz);
            Console.Read();
        }
    }
}
