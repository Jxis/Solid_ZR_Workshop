using Cafeteria.Domain;

namespace Cafeteria.Interface
{
    public interface IPriceCalculator
    {
        public decimal CalculatePrice(Coffee coffee);

    }
}
