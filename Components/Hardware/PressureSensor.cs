using System;
using CoffeeMaker.Common;

namespace CoffeeMaker.Components.Hardware
{
    public class PressureSensor : ISensor
    {
        public PressureSensor()
        {
        }

        public bool HasThresholdBeenBreached()
        {
            //logic for checking pressure threshold
            throw new NotImplementedException();
        }
    }
}
