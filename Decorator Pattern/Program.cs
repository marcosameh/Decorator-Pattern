// See https://aka.ms/new-console-template for more information
using Decorator_Pattern.StarBuz;



IBeverage beverage = new Coffee();
Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

IBeverage beverage2 = new Coffee();
beverage2 = new WithMilk(beverage2);

Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
IBeverage beverage3 = new Coffee();
beverage3 = new WithMilk(beverage3);
beverage3 = new WithWhipCream(beverage3);

Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());