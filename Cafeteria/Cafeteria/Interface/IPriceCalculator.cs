using Cafeteria.Domain;

namespace Cafeteria.Interface
{
    public interface IPriceCalculator
    {
        public double CalculatePriceForType(Coffee coffee);
        public double CalculatePriceForSize(Coffee coffee);
        public double CalculatePriceForToppings(Coffee coffee);
        public double CalculatePriceForService(Coffee coffee);

    }
}
