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

        }
        public string Name { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public long CitizenNumber { get; set; }
        public char Gender { get; set; }

        public void WriteInfo()
        {
            Console.WriteLine("Name: " + Name + "\nAge: " + 
                                Age + "\nPhoneNumber: " + 
                                PhoneNumber + "\nCitizenNumber: "
                                + CitizenNumber + "\nGender: " 
                                + Gender);
        }
    }
}
