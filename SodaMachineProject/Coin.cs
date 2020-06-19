using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public abstract class Coin
    {
        // Member Variables (HAS A)
        protected double value;
        public string name;

        // Properties
        public double Value
        {
            get
            {
                return value;
            }
        }

        // Constructor (SPAWNER)
        public Coin()
        {
            
        }

        // Member Methods (CAN DO)
    }
}
