using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public long CitizenNumber { get; set; }

        public char Gender { get; set; }

        public User(long CitizenNumber)
        {
            this.CitizenNumber = CitizenNumber;
        }
        //public User(string name,int  age, string phone,long citizen, char gender )
        //{
        //    //Name = name;
        //    //Age = age;
        //    //PhoneNumber = phone;
        //    //CitizenNumber = citizen;
        //    //Gender = gender;

        //    Console.WriteLine(@"Name: {0} \nAge: {1} \n");
        //}

        public User()
        {
            this.Name = "default";
            this.Age = 0;
            this.PhoneNumber = "55555555";
            this.CitizenNumber = 000000000000000000;
            this.Gender = '-';
        }

        public void WriteInfo()
        {
            Console.WriteLine("Name :"+Name , "\nAge:" + Age +"\nPhone Number :"+PhoneNumber+"\n Citizen Number :"+CitizenNumber+"\nGender :"+Gender);
        }
    }
}
