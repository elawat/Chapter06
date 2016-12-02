using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packt.CS6;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Misiu Jogi";
            p1.DateOfBirth = new DateTime(1980, 12, 24);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth: dddd, d MMMM yyyy}");
            // curly brackets for initializing
            var p2 = new Person { Name = "Mis Puchatek", DateOfBirth = new DateTime(1975, 12, 24) };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth: dddd, d MMMM yyyy}");

        }
    }
}
