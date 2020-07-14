using System;
namespace CoffeeMaker.Components.Hardware
{
    public class Valve
    {
        private PressureSensor _pressureSensor;

        public Valve()
        {
            _pressureSensor = new PressureSensor();
        }

        public bool IsPressureBelowThreshold()
        {
            return _pressureSensor.HasThresholdBeenBreached();
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
