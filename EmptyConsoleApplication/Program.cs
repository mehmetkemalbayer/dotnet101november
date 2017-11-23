using System;


namespace EmptyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("işlem için sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("işlem için ikini sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            SimpleCalculator sCalc = new SimpleCalculator(sayi1, sayi2);
            Console.WriteLine("toplam={0}", sCalc.Sum());
            Console.Read();
        }
    }
}
