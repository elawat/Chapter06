using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.CS6
{
    public class Person 
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


    }
}
