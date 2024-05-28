using System;

namespace Decorator_Pattern.StarBuz
{
    public class WithWhipCream : IBeverage
    {
        private readonly IBeverage beverage;

        public WithWhipCream(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double Cost()
        {
            return beverage.Cost() + 0.5;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + ", Whip Cream";
        }
    }
}
