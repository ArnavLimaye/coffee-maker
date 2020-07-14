using System;

namespace CoffeeMaker
{
    class Runner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press the option for what you want to do");
            Console.WriteLine("1. Brew Coffee\n2. Remove pot");
            int userOption = Int32.Parse(Console.ReadLine());
            CoffeeMakerAPI coffemakerAPI = new CoffeeMakerAPI();
        }
    }
}
