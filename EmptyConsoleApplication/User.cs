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

		public short Age { get; set; }

		public string PhoneNumber { get; set; }

		public long CitizanNumber { get; set; }

		public char Gender { get; set; }

		////public User(string Name, short Age, string PhoneNumber, long CitizanNumber, char Gender)
		////{
		////	this.Name = Name;
		////	this.Age = Age;
		////	this.PhoneNumber = PhoneNumber;
		////	this.CitizanNumber = CitizanNumber;
		////	this.Gender = Gender;
		////}

		public User()
		{
			this.Name = "Default";
			this.Age = 0;
			this.PhoneNumber = "555555555555";
			this.CitizanNumber = 0;
			this.Gender = '-';

		}

		public void WriteInfo()
		{
			Console.WriteLine("Name: " +Name + "\nAge: " +Age +"\nPhoneNumber: " +PhoneNumber +
								"\nCitizanNumber: " +CitizanNumber +"\nGender: " +Gender);
			
		}
		
	}
}
