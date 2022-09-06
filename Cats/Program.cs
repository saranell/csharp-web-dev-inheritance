using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!

            //Create an instance of HouseCat & call some methods it inherits from Cat class:
            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);

            //Confirm the no argument constructor has been called:
            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);
        }
    }
}
