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

            string fullName = "Yavuz Gençoğlu";
            short experience = 5;
            string department = "GullsEye";
            string programingLanguages = ".net,EBA,MsSQL";
            string expectetion = "Bu işi yapabileceğimi düşünerek ayrılacağım";

            Console.WriteLine("İsim : " + fullName);
            Console.WriteLine("Tecrübe : " + experience);
            Console.WriteLine("Departman : " + department);
            Console.WriteLine("Diller : " + programingLanguages);
            Console.WriteLine("Beklenti : " + expectetion);

        }
    }
}
