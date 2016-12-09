using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.CS6
{
    public partial class Person
    {
        // property - methid that act like a field when you want to get or set value

        // property defined using C# 1-5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using C# 6 lambda expression syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => (int)(DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);

        public string FavouriteIceCream { get; set; } // auto-syntax for property

        private string favouritePrimaryColour; //private field to store value for property
        public string FavouritePrimaryColour
        {
            get
            {
                return favouritePrimaryColour;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColour = value;
                        break;
                    default:
                        throw new ArgumentException($"{value} is not a primary colour. Choose from: red, green, blue");
                }
            }
        }


    }
}
