using Cafeteria.Domain;
using Cafeteria.Enums;
using Cafeteria.Interface;

namespace Cafeteria.Calculator
{
    public class ToppingsCalculatorDecorator : PriceCalculatorDecorator
    {
        public ToppingsCalculatorDecorator(IPriceCalculator calculator) : base(calculator) { }

        public override decimal CalculatePrice(Coffee coffee)
        {
            decimal basePrice = base.CalculatePrice(coffee);

            foreach (var item in coffee.Toppings)
            {
                if (item == CoffeeToppings.Cinnamon)
                    basePrice += 0.5m;
                if (item == CoffeeToppings.Milk)
                    basePrice += 0.8m;
                if (item == CoffeeToppings.BrownSugar)
                    basePrice += 0.2m;
            }

            return basePrice;
        }
    }
}
