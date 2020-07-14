using System;
namespace CoffeeMaker.Components.Hardware
{
    public class Valve
    {
        private PressureSensor _pressureSensor;

        public Valve()
        {
        }

        public bool IsPressureBelowThreshold()
        {
            throw new NotImplementedException();
        }

        public bool ReducePressure()
        {
            throw new NotImplementedException();
        }

        public bool ApplyPressure()
        {
            throw new NotImplementedException();
        }
    }
}
