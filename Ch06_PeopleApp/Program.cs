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
            p1.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            //p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabilon | WondersOfTheAncientWorld.MuasoleumAtHalicarnassus;
            p1.BucketList = (WondersOfTheAncientWorld)15 ;
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
        }
    }
}
