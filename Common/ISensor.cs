using System;
namespace CoffeeMaker.Common
{
    public interface ISensor
    {
        // need to find better name
        public bool HasThresholdBeenBreached();
    }
}
