using System;


namespace EmptyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            User firstUser = new User(5);
            Console.WriteLine("birinci kullanıcı : ");
            firstUser.WriteInfo();
            User secondUser = new User();
            Console.WriteLine("\nikinci kullanıcı : ");
            secondUser.WriteInfo();
            Console.Read();

        }
    }
}
