using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tutar Giriniz: ");
            string girilenTutar = Console.ReadLine();
            var convertDecimal = Convert.ToDecimal(girilenTutar);
            Console.WriteLine(girilenTutar + " girdiniz.");


            Console.WriteLine("Yıllık Faizi Giriniz: ");
            string girilenFaiz = Console.ReadLine();
            var convertInterest = Convert.ToDecimal(girilenFaiz);
            Console.WriteLine(convertInterest + " faiz oranıyla hesaplama yapılacak.");

            Console.WriteLine("Kaç Yıl Vade ile İşlem Yapılacağını Giriniz: ");
            string girilenYil = Console.ReadLine();
            var vadeYil = Convert.ToDecimal(girilenYil);
            Console.WriteLine(vadeYil + " yıl için faiz hesaplanacak.");

            Console.ReadLine();
            decimal futureValue = (convertInterest * convertDecimal / 100) + convertDecimal;
            Console.WriteLine("Dönem Sonunda Ödenecek Tutar: " + futureValue);
            Console.ReadLine();
        }
    }
}
