using Cafeteria.Domain;
using Cafeteria.Interface;

namespace Cafeteria.Calculator
{
    public class PriceCalculatorDecorator : IPriceCalculator
    {
        private readonly IPriceCalculator _calculator;

        public PriceCalculatorDecorator(IPriceCalculator calculator)
        {
            _calculator = calculator;
        }

        public virtual decimal CalculatePrice(Coffee coffee)
        {
            return _calculator.CalculatePrice(coffee);
        }

    }
}
