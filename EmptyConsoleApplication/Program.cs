using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyConsoleApplication
{

    class Programer
    {
        static void Main(string[] args)

        {
            Animal Animal = new Animal();
            Animal.AnimalSound();

            Dog Dog = new Dog();
            Dog.DogSound();

            Cat Cat = new Cat();
            Cat.CatSound();

            Mouse Mouse = new Mouse();
            Mouse.MouseSound();

            Console.ReadLine();
        }

    }
}