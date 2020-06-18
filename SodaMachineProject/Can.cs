using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public abstract class Can
    {
        // Member Variables (HAS A)
        protected double cost;
        public string name;

        // Properties
        public double Cost
        {
            get
            {
                return cost;
            }

        }


        // Constructor (SPAWNER)
        public Can()
        {
           
            
        }

        // Member Methods (CAN DO)

    }
}
