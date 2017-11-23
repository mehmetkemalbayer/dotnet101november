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
            Name = "Default";
            Age = 0;
            PhoneNumber = "55555555";
            CitizenNumber = 0;
            Gender = '-';
        }

        public User(long CitizenNumber)
        {
            this.CitizenNumber = CitizenNumber;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        public short Age { get; set; }

        public string PhoneNumber { get; set; }

        public long CitizenNumber { get; set; }

        public char Gender { get; set; }

        public void WiteInfo()

        {

            Console.WriteLine("Name : " + Name + "\n Age : " + Age + "\n PhoneNumber : " + PhoneNumber + "\n CitizenNumber : " + CitizenNumber + "\nGender : " + Gender);

        }

        public void WiteInfo1()

        {

            Console.WriteLine("Name : " + Name + "\n Age : " + Age + "\n PhoneNumber : " + PhoneNumber + "\n CitizenNumber : " + CitizenNumber + "\nGender : " + Gender);

        }

    }


    }
