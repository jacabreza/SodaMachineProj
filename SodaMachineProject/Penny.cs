using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Penny : Coin
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Penny(string name)
        {
            this.name = name;
            value = 0.01;
        }

        // Member Methods (CAN DO)
    }
}
