using Cafeteria.Domain;
using Cafeteria.Enums;
using Cafeteria.Interface;

namespace Cafeteria.Calculator
{
    
    public class TypeCalculatorDecorator : PriceCalculatorDecorator
    {
        public TypeCalculatorDecorator(IPriceCalculator calculator) : base(calculator)
        {
        }

        public override decimal CalculatePrice(Coffee coffee)
        {
            decimal basePrice = base.CalculatePrice(coffee);
            if (coffee.Type == CoffeeType.Espresso)
                basePrice = 1.0m;
            else if (coffee.Type == CoffeeType.Cappuccino)
                basePrice = 2.0m;
            else if (coffee.Type == CoffeeType.LatteMacchiato)
                basePrice = 3.0m;

            return basePrice;
        }
    }
}
