using System;

public class User
{
    public string Name { get; set; }
    public short Age { get; set; }
    public string PhoneNumber { get; set; }
    public long Citizen { get; set; }
    public char Gender { get; set; }

    public User(short age)
    {
        Age = age;
    }

    public User()
    {
        Name = "Default";
        Age = 0;
        PhoneNumber = "5555555555";
        Citizen = 0;
        Gender = '-';
    }

    public void WriteInfo()
    {
        Console.WriteLine("Name: " + Name + "\nAge  : " + Age + "\nPhone:" + PhoneNumber + "\nCitizen:" + Citizen + "\nGender: " + Gender);
    }
}
