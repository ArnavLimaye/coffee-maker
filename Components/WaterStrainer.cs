using System;
using CoffeeMaker.Components.Hardware;

namespace CoffeeMaker.Components
{
    internal class WaterStrainer : IStatusChecker
    {
        private Valve _valve;
        public WaterStrainer()
        {
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool ShouldStopWaterFlow()
        {
            //call valve's isPressureBelow
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public void BoilWater()
        {
            
        }
    }
}
