using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class User
    {
        public User()
        {
            Name = "default";
            Age = 0;
            telefon = "55555555555";
            citizen = 00000000000000;
            gender = '-';
        }

        public string Name { get; private set; }
        public short Age { get; private set; }
        public  string telefon { get; private set; }
        public  long citizen { get; private set; }
        public char gender { get; private set; }
        
        public void writeInfo()
        {
            Console.WriteLine("name:" + Name + "\nAge:" + Age + "\ntelefon" + telefon + "\ncitizen:" + citizen + "\ngender:" + gender);
        }


    }
}
