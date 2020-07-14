using System;
using CoffeeMaker.Components;
using CoffeeMaker.Components.Hardware;

namespace CoffeeMaker
{
    public class CoffeeMakerAPI
    {
        private CoffeeContainer _coffeeContainer;
        private Filter _filter;
        private WaterStrainer _waterStrainer;
        private WarmerPlate _warmerPlate;

        public CoffeeMakerAPI()
        {
            _coffeeContainer = new CoffeeContainer();
            _filter = new Filter();
            _waterStrainer = new WaterStrainer();
            _warmerPlate = new WarmerPlate();
        }

        public bool IsCoffeeReady()
        {
            if (_coffeeContainer.IsFull())
            {
                return true;
            }
            return false;
        }

        public void StartBrewing()
        {
            if (AreAllPrerequisitesMet())
            {
                // logic for brewing
                _waterStrainer.StartBoiler();
                if (_coffeeContainer.IsFull())
                {
                    _waterStrainer.StopBoiler();
                    _warmerPlate.Start();
                }
            }
            else
            {
                Console.WriteLine("respective warnings for user");
            }
        }

        private bool AreAllPrerequisitesMet()
        {
            if(_coffeeContainer.IsEmpty() || _coffeeContainer.HasBeenRemoved() || _coffeeContainer.IsFull())
            {
                return false;
            }
            if(_filter.IsEmpty())
            {
                return false;
            }
            if(_waterStrainer.IsEmpty())
            {
                return false;
            }
            return true;
        }
    }
}
