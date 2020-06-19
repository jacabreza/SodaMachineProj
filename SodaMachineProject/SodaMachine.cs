using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class SodaMachine
    {
        // Member Variables (HAS A)
        public List<Coin> register;
        public List<Can> inventory;
        // public Customer customer;

        // Constructor (SPAWNER)
        public SodaMachine()
        {
            // customer = new Customer();
            register = new List<Coin>();
            inventory = new List<Can>();
            MoneyInRegister();
            SodaInventory();

        }
        // Member Methods (CAN DO)
        public void PerformTransaction(Customer customer)
        {
            UserInterface.DisplaySodaOptions();                     // display options (SodaMachine, UserInterface)
           // UserInterface.PickingSoda();                          
            CustomersChoiceOfSoda(customer);                        // get user input (which soda?)
          //  List<Coin> coinsInHand = customer.InsertingCoins();     // get coins from customer
                                                                // if they provided enough money.. (Remember, one thing at a time!)

        }


        private void MoneyInRegister()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter("Quarter"));
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime("Dime"));
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Nickle("Nickle"));
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny("Dime"));
            } 

        }


        private void SodaInventory()
        { 
            for (int i = 0; i < 12; i++)
            {
                inventory.Add(new RootBeer("RootBeer"));
            }
            for (int i = 0; i < 12; i++)
            {
                inventory.Add(new Cola("Cola"));
            }
            for (int i = 0; i < 12; i++)
            {
                inventory.Add(new Orange("Orange"));
            }

        }

        public void CustomersChoiceOfSoda(Customer customer)   
        {
            Can dispensedCan = UserInterface.PickingSoda();

            List<Coin> coinsInHand = customer.InsertingCoins();

            double totalValueOfCoins = TotalValueOfCoins(coinsInHand);



            


            if (totalValueOfCoins > dispensedCan.Cost)
            {
                if (inventory < inventory.Count)
                {
                    
                    //insufficient inventory for Soda
                }
                else if (totalValueOfCoins > register)
                {
                    //insufficient change in Register
                }
                else if ()
                {
                    //Too much Funds, accept payment, and return change
                }

            }

            else if (totalValueOfCoins < dispensedCan.Cost)
            {

                  //Not enough Funds
            }

            else if (totalValueOfCoins == dispensedCan.Cost) 
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i].name == dispensedCan.name)       //Exact amount of Funds
                    {
                        inventory.RemoveAt(i);
                        customer.AddCansToBackPack(dispensedCan);
                        break;
                    }
                }
            }






            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name == dispensedCan.name)
                {
                    inventory.RemoveAt(i);
                    customer.AddCansToBackPack(dispensedCan);
                    break;
                }

            }

        }

        public double TotalValueOfCoins(List<Coin> coins)
        {
            double totalValue = 0;

            for (int i = 0; i < coins.Count; i++)
            {
                totalValue += coins[i].Value;
            }

            return totalValue;
        }




    }

}
