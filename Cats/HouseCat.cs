using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";

        //To use a Cat constructor for HouseCat, we must provide it (doesn't inherit constructors from Cat class):
        public HouseCat(string name, double weight) : base(weight) // the call to the base class must be on the constructor signature
        {
        // ": base(weight)" allows this constructor to extend the Cat class constructor that takes a weight parameter 

            Name = name; //Setting the value for the name
        }

        // On the next line, write a constructor that uses the no-arg constructor in the Cat class.
        public HouseCat(string name)
        {
            Name = name;
            //By doing this, we can initialize a new HouseCat with just the name field
        }
        


        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            return "Hello, my name is " + Name + "!";
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
