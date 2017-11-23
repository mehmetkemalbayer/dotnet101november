using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class User
    {
        public User(long CitizenNumber)
        {
            this.CitizenNumber = CitizenNumber;
        }

        public User()
        {
            this.Name = "Default";
            this.PhoneNumber = "5555555555";
            this.Gender = Convert.ToChar("-");

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public long CitizenNumber { get; set; }
        public char Gender { get; set; }

        public void WriteInfo()
        {
            Console.WriteLine("Name: " + Name + "\nAge: " + Age + "\nPhoneNumber: " + PhoneNumber + "\nCitizenNumber: " + CitizenNumber + "\nGender: " + Gender);
 //         Console.WriteLine("Name: {0}\nAge: {1}\nPhoneNumber: {2}\nCitizenNumber: {3}\nGender: " Name, PhoneNumber, CitizenNumber, Gender);
        }
    }
}
