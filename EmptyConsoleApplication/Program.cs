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
            //string companyName="Softtech";

            //string fullName = "Öykü BİLEN";
            //short experience = 8;
            //string department = "Uygulama Destek";
            //string programmingLanguages = "ASP.NET MVC,C#,C,MATLAB,JAVA,SQL";
            //string expectation = "Kurs süresince bilgi birikimi ile kendimi geliştirerek ileriye yönelik bir kazanç sağlamak";

            //WriteName(fullName);
            //WriteExperience(experience);

            //Console.WriteLine("Programlama dilleri :" + programmingLanguages);
            //Console.WriteLine("Beklenti :" + expectation);

            //int toplam=0;

            //for (int i = 0; i < 1000; i++)
            //{
            // toplam+=i;
            //}
            //Console.WriteLine(toplam);

            double faiz;
            double faizOran;
            Console.WriteLine("Ana parayı giriniz :");
            string para=Console.ReadLine();
            Console.WriteLine("Faiz oranını giriniz");
            string faizOran1=Console.ReadLine();
            faizOran=Convert.ToDouble(faizOran1);
            decimal anapara = Convert.ToDecimal(para);
            Console.WriteLine("zaman giriniz :");
            string zaman=Console.ReadLine();
            int zaman1=Convert.ToInt32(zaman);
            faiz=((double)(anapara)*zaman1*faizOran)/100;

            Console.WriteLine("faiz oranı :"+faiz);





           
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
