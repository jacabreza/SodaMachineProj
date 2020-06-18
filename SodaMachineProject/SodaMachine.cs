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

        // Constructor (SPAWNER)
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            MoneyInRegister();
            SodaInventory();

        }
        // Member Methods (CAN DO)
        public void PerformTransaction(Customer customer)
        {
            // display options (SodaMachine, UserInterface)
            // DisplaySodaOptions(); (Userinterface.displaysodaoptions)

            // get user input (which soda?)
            // display price of selection
            // get coins from customer
            List<Coin> coinsInHand = customer.InsertingCoins();
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

        private void CustomersOptionForSoda()
        {
            //switch case for choices of soda
        }


    }

}
