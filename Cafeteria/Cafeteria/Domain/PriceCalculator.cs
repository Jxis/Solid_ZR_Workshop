using Cafeteria.Interface;

namespace Cafeteria.Domain
{
    public class PriceCalculator : IPriceCalculator
    {
        public double FinalPrice {get;set;}
        public PriceCalculator(Coffee coffee) {
            FinalPrice = CalculatePriceForService(coffee);
        }
        public double CalculatePriceForType(Coffee coffee) {
            if (coffee.Type == CoffeeType.Espresso)
                coffee.Price = 1.0;
            else if (coffee.Type == CoffeeType.Cappuccino)
                coffee.Price = 2.0;
            else if (coffee.Type == CoffeeType.LatteMacchiato)
                coffee.Price = 3.0;

            return coffee.Price;
        }

        public double CalculatePriceForSize(Coffee coffee) {
            CalculatePriceForType(coffee);
            if (coffee.Size == CoffeeSize.Large)
                coffee.Price += 0.7;

            return coffee.Price;   
        }

        public double CalculatePriceForToppings(Coffee coffee)
        {
            CalculatePriceForSize(coffee);
            
            foreach (var item in coffee.Toppings)
            {
                if (item == CoffeeToppings.Cinnamon)
                    coffee.Price += 0.5;
                if (item == CoffeeToppings.Milk)
                    coffee.Price += 0.8;
                if (item == CoffeeToppings.BrownSugar)
                    coffee.Price += 0.2;
            }

            return coffee.Price;
        }

        public double CalculatePriceForService(Coffee coffee)
        {
            CalculatePriceForToppings(coffee);
            if (coffee.serviceType == ServiceType.CouponCode)
            {
                double discountRate = 0.05;
                double discountAmount = coffee.Price * discountRate;
                coffee.Price -= discountAmount;
            }
            else if (coffee.serviceType == ServiceType.TakeAway) 
            {
                if (coffee.Price <= 7.00)
                {
                    coffee.Price *= 1.2;
                }
            }

            return coffee.Price;
        }

        
    }
}
