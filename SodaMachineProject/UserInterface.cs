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
        public static string DisplaySodaOptions()
        {
            Console.WriteLine("\tRoundy's Soda Machine!");
            Console.WriteLine("RootBeer $0.60");
            Console.WriteLine("Cola $0.35");
            Console.WriteLine("Orange $0.06");
            
            return null;
        }


        public static Can PickingSoda()
        {
            Console.WriteLine("\n\tPlease pick from the following Soda Options: ");
            Console.WriteLine("Press [0] for RootBeer $0.60");
            Console.WriteLine("Press [1] for Cola $0.35");
            Console.WriteLine("Press [2] for Orange $0.06");

            string inputFromUser = Console.ReadLine();

            Can userInput;
            switch (inputFromUser)
            {
                case "0":
                    userInput = new RootBeer("RootBeer");
                    return userInput;
                case "1":
                    userInput = new Cola("Cola");
                    return userInput;
                case "2":
                    userInput = new Orange("Orange");
                    return userInput;

                    //come back for valiation

            }
            Console.WriteLine("Invalid Response");
            return null;

        }


        public static string GetCoinSelection()
        {
            Console.WriteLine("\n\tPlease choose a coin to insert:");
            Console.WriteLine("Press [0] for Quarter.");
            Console.WriteLine("Press [1] for Dime.");
            Console.WriteLine("Press [2] for Nickel.");
            Console.WriteLine("Press [3] for Penny.");
            Console.WriteLine("Press [4] when you are Finished.");

            string userInput = Console.ReadLine();
            return userInput;

        }

       

      
        



    }
}
