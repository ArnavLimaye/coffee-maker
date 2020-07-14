using System;
namespace CoffeeMaker.Components
{
    internal class CoffeeContainer : IStatusChecker
    {
        public CoffeeContainer()
        {
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public bool HasBeenRemoved()
        {
            // call weight sensor's method
            throw new NotImplementedException();
        }
    }
}
