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
            Console.WriteLine("Bir sayı giriniz");
            var sayi1 = Console.ReadLine();
            Console.WriteLine("Bir sayı daha giriniz");
            var sayi2 = Console.ReadLine();
            if (string.IsNullOrEmpty(sayi2))
            {
                throw new EmptyStringException();
            }
            int number1 = Convert.ToInt32(sayi1);
            int number2 = Convert.ToInt32(sayi2);
            Console.WriteLine("Toplam = {0}", number1 + number2);
            try
            {
               
            }
            catch (EmptyStringException ex)
            {
                Console.WriteLine("Giriş değeri boş bırakılamaz.");
                Console.ReadLine();
            }
            catch (FormatException  ex)
            {
                Console.WriteLine("Uyumsuz format");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Girdiğiniz rakam formatı uygun değil.");
                Console.ReadLine();
            }


        }

    }
}
