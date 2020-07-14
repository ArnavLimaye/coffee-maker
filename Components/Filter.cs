using System;
namespace CoffeeMaker.Components
{
    internal class Filter : IStatusChecker
    {
        public Filter()
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
    }
}
