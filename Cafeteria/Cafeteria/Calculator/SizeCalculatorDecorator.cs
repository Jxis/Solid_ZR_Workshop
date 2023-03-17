using Cafeteria.Domain;
using Cafeteria.Enums;
using Cafeteria.Interface;

namespace Cafeteria.Calculator
{
    public class SizeCalculatorDecorator : PriceCalculatorDecorator
    {
        public SizeCalculatorDecorator(IPriceCalculator calculator) : base(calculator) { }

        public override decimal CalculatePrice(Coffee coffee)
        {
            decimal basePrice = base.CalculatePrice(coffee);

            if (coffee.Size == CoffeeSize.Large)
            {
                basePrice += 0.7m;
            }

            return basePrice;
        }
    }
}
