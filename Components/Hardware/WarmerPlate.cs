using System;
namespace CoffeeMaker.Components.Hardware
{
    public class WarmerPlate :IStatusChecker
    {
        private WeightSensor _weightSensor;
        public WarmerPlate()
        {
            _weightSensor = new WeightSensor();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public bool Start()
        {
            if(!IsEmpty())
            {
                //start warming
            }
            throw new NotImplementedException();
        }
    }
}
