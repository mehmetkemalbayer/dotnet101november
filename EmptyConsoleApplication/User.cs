﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{
    class User   
    {        
        public string Name { get; set; }
        public short  Age { get; set; }
        public string PhoneNumber { get; set; }
        public long CitizenNumber { get; set; }
        public char Gender { get; set; }

        public User()
        {
            this.Name = "Default";
            this.Age = 0;
            this.PhoneNumber = "5555555555";
            this.CitizenNumber = 0;
            this.Gender = '-';
        }
        public void writeinfo()
        {
            Console.WriteLine("Name: " + Name + "\nAge: " + Age + "\nPhoneNumber: " + PhoneNumber + "\nCitizenNumber: " + CitizenNumber + "\nGender : " + Gender );
            
        }
            
    }
}
