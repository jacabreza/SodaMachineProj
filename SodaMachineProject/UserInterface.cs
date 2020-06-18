using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class UserInterface
    {
        public static string CustomersChoiceOfSoda()
        {
            Console.WriteLine("What soda would you like to purchase?");
            string inputFromUser = Console.ReadLine();
            return inputFromUser;

        }

        public static string GetCoinSelection()
        {
            Console.WriteLine("Please choose a coin to insert:");
            Console.WriteLine("Press [0] for quarter.");
            Console.WriteLine("Press [1] for dime.");
            Console.WriteLine("Press [2] for nickel.");
            Console.WriteLine("Press [3] for penny.");
            Console.WriteLine("Press [4] to finish.");

            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
