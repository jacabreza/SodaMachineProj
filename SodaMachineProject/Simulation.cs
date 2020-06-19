using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Simulation
    {
        // Member Variables (HAS A)
        public SodaMachine sodaMachine;
        public Customer customer;

        // Constructor (SPAWNER)
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }

        // Member Methods (CAN DO)

        public void RunSimulation()
        {
            sodaMachine.PerformTransaction(customer);
            //Display Soda Options and Price
                
            //Make a Decision to buy said item
            //Customer checks out item

        }


    }
}
