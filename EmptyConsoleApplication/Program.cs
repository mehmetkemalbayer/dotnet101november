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
            int minDeger = 0;
            int maxDeger = 100;
            int tahmin = 50;
            string durum = "r";
            while (durum!="d")
            {

                Console.WriteLine("tuttuğun sayı " + tahmin + " mi ?");
                durum= Console.ReadLine();

                if (durum == "k")
                {
                    maxDeger = tahmin;
                    tahmin = minDeger + (maxDeger - minDeger) / 2; 

                }
                if (durum == "b")
                {
                    minDeger = tahmin;
                    tahmin = minDeger + (maxDeger - minDeger) / 2;
                }
                
                    
                }


                    

            }
            }

        }        

