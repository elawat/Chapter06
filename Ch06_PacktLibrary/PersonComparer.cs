using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Packt.CS6
{
    public class PersonComparer : IComparer<Person> // defining a separate comparer
    {
        public int Compare(Person x, Person y) //compares two poeple names by comparing first length of their name, then comparing alphabetically
        {
            int temp = x.Name.Length.CompareTo(y.Name.Length);
            if (temp == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return temp;
            }
        }
    }
}
