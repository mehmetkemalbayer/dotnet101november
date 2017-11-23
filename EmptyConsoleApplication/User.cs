using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class User
    {
        public User(long citizennumber)
        {
            this.CitizenNumber = citizennumber;
        }
        public User()
        {
            this.Name = "Default";
            this.Age = 0;
            this.PhoneNumber = "55555555";
            this.CitizenNumber = 0000000000;
            this.Gender = '-';
        }
        public string Name{ get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public long CitizenNumber { get; set; }
        public char Gender { get; set; }
        public void WriteInfo (){
            Console.WriteLine("Name: " + Name + "\nAge: " + Age + 
                "\nPhone Number: " + PhoneNumber + "\nCitizenNumber: " + CitizenNumber 
                + "\nGender: "+ Gender);
            Console.WriteLine("Name: {0}\nAge: {1}\nPhone Number: {2}\nCitizenNumber: {3}\nGender: {4}" + Gender,Name,Age,PhoneNumber,CitizenNumber,Gender);
        }
    }
}
