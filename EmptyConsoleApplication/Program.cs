﻿using System;
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
            string fullName = "Serdar Uz";
            short experience = 11;
            string department = "Süreç ve Ölçme";
            string programmingLanguages = "excel vba, rexx, jcl";
            string expectation = "C# esaslarını öğrenerek iş için bir temel oluşturmak";
            Console.WriteLine("İsim: " + fullName);
            Console.WriteLine("Deneyim " + experience);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Diller: " + programmingLanguages);
            Console.WriteLine("Beklenti: " + expectation);
            Console.ReadLine();
        }
    }
}
