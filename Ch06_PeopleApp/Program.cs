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
        private static Array people;

        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Misiu Jogi";
            p1.DateOfBirth = new DateTime(1980, 12, 24);
            p1.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            //p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabilon | WondersOfTheAncientWorld.MuasoleumAtHalicarnassus;
            p1.BucketList = (WondersOfTheAncientWorld)15;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth: dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");
            // curly brackets for initializing
            var p2 = new Person { Name = "Mis Puchatek", DateOfBirth = new DateTime(1975, 12, 24) };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth: dddd, d MMMM yyyy}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} has {p1.Children.Count} children");

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate}.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Smith";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate}.");

            WriteLine($"{p1.Name} is a {Person.Species}.");

            WriteLine($"{p1.Name} was born on {p1.HomePlanet}.");

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}.");

            var p4 = new Person("Dawid");
            WriteLine($"{p4.Name} was instantiated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, d MMMM yyyy}.");

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            WriteLine(p1.SayHello());
            WriteLine(p1.SayHello("Ela"));

            p1.OptionalParameters("Jump!", 15);
            p1.OptionalParameters("Jump!", active: false);

            var max = new Person { Name = "Max", DateOfBirth = new DateTime(1986, 8, 17) };
            WriteLine(max.Origin);
            WriteLine(max.Greeting);
            WriteLine(max.Age);

            max.FavouriteIceCream = "Chocolate Fundge";
            WriteLine($"Max's favourite ice cream flavour is {max.FavouriteIceCream}");
            max.FavouritePrimaryColour = "Red";
            WriteLine($"Max's favourite primary colour is {max.FavouritePrimaryColour}");

            max.Children.Add(new Person { Name = "Charlie" });
            max.Children.Add(new Person { Name = "Ella" });
            WriteLine($"Max's first child is {max.Children[0].Name}");
            WriteLine($"Max's second child is {max.Children[1].Name}");
            WriteLine($"Max's first child is {max[0].Name}"); // uses indexers
            WriteLine($"Max's secod child is {max[1].Name}");

            WriteLine();

            var harry = new Person("Harry"); // creating a new instance of Person with field Name = "Harry"
            var mary = new Person { Name = "Mary" }; // creating a new instance of Person with field Name = "Mary"
            var baby1 = harry.Procreate(mary);
            // with the use of operator
            var baby2 = mary * harry;
            WriteLine($"{harry.Name} has {mary.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{baby1.Name}");

            // Calling methid directly
            int answer = p1.MethodIWantToCall("Frod");
            // Create instance of delegate, point it at the method, and call the delegate (which calls the method)
            //?????
            //var d = new DelegateWithMatchingSignature(p1.MethodIWantToCall);
            //int answer2 = d("Frod");

            p1.Shout += P1_Shout; // tab + enter to insert method taht matches teh signature of the event delegate 
            p1.Poke();
            p1.Poke();
            p1.Poke();
            p1.Poke();
            //p1.Poke();


            Person[] people =
       {
            new Person {Name = "Simon" },
            new Person {Name = "Jenny" },
            new Person {Name = "Adam" },
            new Person {Name = "Richard" }
        };
            Array.Sort(people); // uses IComparable interface method - CompareTo method
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            Array.Sort(people, new PersonComparer()); // we explicitly ask the sorting algorithm to use the PersonComparer - Compare method
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

        }

        private static void P1_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: { p.AngerLevel}.");
        }

       
         
    }
}
