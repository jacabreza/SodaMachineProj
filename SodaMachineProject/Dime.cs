using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Dime : Coin
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Dime(string name)
        {
            this.name = name;
            value = 0.10;
        }

        // Member Methods (CAN DO)
    }
}
