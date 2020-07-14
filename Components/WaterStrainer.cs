using System;
using CoffeeMaker.Components.Hardware;

namespace CoffeeMaker.Components
{
    internal class WaterStrainer : IStatusChecker
    {
        private Valve _valve;
        private Boiler _boiler;

        public WaterStrainer()
        {
            _valve = new Valve();
            _boiler = new Boiler();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void StopBoiler()
        {
            //call valve's isPressureBelow
            if (_valve.IsPressureBelowThreshold())
            {
                _boiler.Stop();
            }
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public void StartBoiler()
        {
            _boiler.Start();
        }
    }
}
