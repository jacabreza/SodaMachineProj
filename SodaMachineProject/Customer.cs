using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Customer
    {
        // Member Variables (HAS A)
        public Wallet wallet;
        public Backpack backpack;
        public string name;


        // Constructor (SPAWNER)
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            name = "";

        }

        // Member Methods (CAN DO)
        public void AddCansToBackPack(Can can)
        {
            backpack.cans.Add(can);
        }
       

        public List<Coin> InsertingCoins()
        {
            List<Coin> coinsToInsert = new List<Coin>();
            bool isStillInsertingCoins = true;
            // double totalNumberOfCoins = 0;

            while (isStillInsertingCoins)
            {
                string userInput = UserInterface.GetCoinSelection();

                switch (userInput)
                {
                    case "0":
                        for (int i = 0; i < wallet.coins.Count; i++)
                        {
                            if (wallet.coins[i].name == "Quarter")
                            {
                                Coin coinToPayWith = wallet.coins[i];
                                wallet.coins.Remove(coinToPayWith);
                                coinsToInsert.Add(coinToPayWith);
                                Console.WriteLine("Quarter was Added");
                                // totalNumberOfCoins += coinToPayWith.Value;
                                break;
                            }
                        }
                        break;

                    case "1":
                        for (int i = 0; i < wallet.coins.Count; i++)
                        {
                            if (wallet.coins[i].name == "Dime")
                            {
                                Coin coinToPayWith = wallet.coins[i];
                                wallet.coins.Remove(coinToPayWith);
                                coinsToInsert.Add(coinToPayWith);
                                Console.WriteLine("Dime was Added");
                                break;
                            }
                        }
                        break;

                    case "2":
                        for (int i = 0; i < wallet.coins.Count; i++)
                        {
                            if (wallet.coins[i].name == "Nickle")
                            {
                                Coin coinToPayWith = wallet.coins[i];
                                wallet.coins.Remove(coinToPayWith);
                                coinsToInsert.Add(coinToPayWith);
                                Console.WriteLine("Nickle was Added");
                                break;
                            }
                        }
                        break;

                    case "3":
                        for (int i = 0; i < wallet.coins.Count; i++)
                        {
                            if (wallet.coins[i].name == "Penny")
                            {
                                Coin coinToPayWith = wallet.coins[i];
                                wallet.coins.Remove(coinToPayWith);
                                coinsToInsert.Add(coinToPayWith);
                                Console.WriteLine("Penny was Added");
                                break;
                            }
                        }
                        break;

                    case "4":
                        isStillInsertingCoins = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Response. Please Try Again!");
                        break;
                }

            } 
            return coinsToInsert;
        }


        public void NotEnoughMoney()
        {
           
        }


        // If not enough money, don’t complete transaction 
        // and give the money back.

        // If exact change, accept payment 
        // and dispense a soda into Backpack.

        // If too much money, accept the payment
        // return change as a list of coins from internal, limited register, 
        // and dispense a soda into Backpack.

        // If too much money, but there isn’t sufficient change in the machine’s register,
        // don’t complete transaction: give the money back.

        // If exact or too much money, but there isn’t sufficient inventory,
        // don’t complete the transaction: give the money back. 




    }

}
