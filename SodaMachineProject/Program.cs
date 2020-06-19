using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Customer customer = new Customer();
            //List<Coin> test = customer.InsertingCoins();

            //customer.wallet.coins.Add(new Quarter());

            //int indexToRemove = -1;

            //for (int i = 0; i < customer.wallet.coins.Count; i++)
            //{
            //    if (customer.wallet.coins[i].Value == .1)
            //    {
            //        indexToRemove = i;
            //        break;
            //    }
            //}

            //customer.wallet.coins.RemoveAt(indexToRemove);

            Simulation simulation = new Simulation();
            simulation.RunSimulation();

        }
    }
}
