using System;

namespace Decorator_Pattern.StarBuz
{
    public class Coffee : IBeverage
    {
        public string GetDescription()
        {
            return "Coffee";
        }

        public double Cost()
        {
            return 2.0;
        }
    }
}
