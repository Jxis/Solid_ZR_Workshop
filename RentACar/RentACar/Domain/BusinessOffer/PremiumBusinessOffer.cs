using RentACar.Interface;

namespace RentACar.Domain.BusinessOffer
{
    public class PremiumBusinessOffer : IBusinessOffer
    {
        public decimal CalculateRentalPrice(decimal Price)
        {
            decimal totalPrice = Price + Price * 0.15m;
            return totalPrice;
        }
    }
}
