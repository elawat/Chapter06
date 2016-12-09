using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Packt.CS6
{
    public partial class Person  // partial allows split the code for class over multiple files
        // if not public will be accessible only withing the assembly that defined it
    {
        // fields
        public string Name; // if private only accessible withing the class
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder; // enum
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>(); // aggregation, collections of Person
        // constants
        public const string Species = "Homo Sapies";
        // read-only field
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // contructor - special category of methods, called when you make an instance of the class using the new keyword
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        // overloading second contructor with args to pass
        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }
        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth: dddd, d MMMM yyyy}");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public void OptionalParameters(string command = "Run", double number = 0.0, bool active = true)
        {
            WriteLine($"command is {command}, number is {number}, active is {active}");
        }

    }
}
