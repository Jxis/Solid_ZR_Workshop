using RentACar.Interface;

namespace RentACar.Domain.BusinessOffer
{
    public class StandardBusinessOffer : IBusinessOffer
    {
        public decimal CalculateRentalPrice(decimal Price)
        {
            decimal newPrice = Price + Price * 0.2m;
            return newPrice;
        }
    }
}
