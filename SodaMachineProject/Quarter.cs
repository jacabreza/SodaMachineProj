using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Quarter : Coin
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Quarter(string name)
        {
            this.name = name;
            value = 0.25;
        }

        // Member Methods (CAN DO)
    }
}
