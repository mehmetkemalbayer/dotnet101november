using System;


namespace EmptyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tahmin oyunumuza başlayalım. bir sayı tut?");

            
            int bas = 0;
            int bit = 100;
            bool isBulundu = false;
            

            while(!isBulundu)
            {
                int yari = (bas + bit) / 2;

                Console.WriteLine("Sayı "+yari+" mi?");
                string sdurum = Console.ReadLine();
                char durum = sdurum[0];
                Console.WriteLine(durum);



                if (durum == 'K')
                {
                    Console.WriteLine("k yı eşit buldu");
                    bit = yari;
                }
                else if (durum == 'B')
                {
                    bas = yari;
                    Console.WriteLine("B yı eşit buldu");
                }
                else 
                {
                    Console.WriteLine("Bingo");
                    isBulundu = true;
                }

                Console.WriteLine("yari : " + yari);
            }
            Console.Read();
        }


    }
}
