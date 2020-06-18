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
        public void BuyingSoda()
        {

        }
        public List<Coin> InsertingCoins()
        {
            List<Coin> coinsToInsert = new List<Coin>();
            bool isStillInsertingCoins = true;

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
                            }
                        }
                        break;

                    case "4":
                        isStillInsertingCoins = false;
                        break;

                    default:
                        Console.WriteLine("Oops! Wrong number.");
                        break;

                        // if I still have one quarter in my wallet...
                        // add a quarter to coinsToInsert   
                        // also take a quarter out of wallet.coins
                }

            } 
            return coinsToInsert;
        }

       





    }

}
