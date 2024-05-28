using System;

namespace Decorator_Pattern.StarBuz
{
    public class WithMilk : IBeverage
    {
        private readonly IBeverage beverage;

        public WithMilk(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double Cost()
        {
            return beverage.Cost() + 1.0;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
