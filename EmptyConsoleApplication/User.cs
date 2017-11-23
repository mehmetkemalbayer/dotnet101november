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
            Name = "Default";
            Age = 0;
            PhoneNumber = "555555555";
            CitizenNumber = 00000000000;
            Gender = '-';
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public long CitizenNumber { get; set; }
        public char Gender { get; set; }

        void GenerateFullName()
        {
            Fullname = Name + Surname;
        }
        public void WriteInfo()
        {
            
            Console.WriteLine("Ad Soyad: " + Fullname + "\nYaş: " + Age + "\nTelefon Numarası: " + PhoneNumber + "\nTCKN: " + CitizenNumber + "\nCinsiyet: " + Gender );
            Console.ReadLine();
        }


    }
}
