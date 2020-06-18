using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Wallet
    {
        // Member Variables (HAS A)
        public List<Coin> coins;
        public Card card;

        // Constructor (SPAWNER)
        public Wallet()
        {
            coins = new List<Coin>();
            CoinsInWallet();

        }

        // Member Methods (CAN DO)
       private void CoinsInWallet()
       {
            for (int i = 0; i < 20; i++)
			{
                coins.Add(new Quarter("Quarter"));
			}
            for (int i = 0; i < 10; i++)
            {
                coins.Add(new Dime("Dime"));
            }
            for (int i = 0; i < 20; i++)
            {
                coins.Add(new Nickle("Nickle"));
            }
            for (int i = 0; i < 50; i++)
            {
                coins.Add(new Penny("Penny"));
            }

       }
    }
}
