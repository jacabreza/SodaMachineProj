using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Cola : Can
    {
        // Member Variables (HAS A)

        // Constructor (SPAWNER)
        public Cola(string name)
        {
            this.name = name;
            cost = 0.35;
        }

        // Member Methods (CAN DO)
    }
}
