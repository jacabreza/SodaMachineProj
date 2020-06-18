using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Nickle : Coin
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Nickle(string name)
        {
            this.name = name;
            value = 0.05;
        }

        // Member Methods (CAN DO)
    }
}
