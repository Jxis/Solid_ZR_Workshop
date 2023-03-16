using RentACar.Interface;

namespace RentACar.Domain.BusinessOffer
{
    public class BusinessOffer 
    {
        public Car car = new Car();

        public BusinessOffer(Car car)
        {
            this.car = car;
        }

        public IBusinessOffer GetBusinessOffer()
        {
            if (car.BusinessOffer == 'S')
            {
                return new StandardBusinessOffer();
            }
            else if (car.BusinessOffer == 'P')
            {
                return new PremiumBusinessOffer();
            }
            else
            {
                throw new ArgumentException($"Invalid business offer type: {car.BusinessOffer}");
            }
        }


        public decimal CalculateRentalPrice()
        {
            IBusinessOffer businessOffer = GetBusinessOffer();
            car.RentalPrice = businessOffer.CalculateRentalPrice(car.Price);
            return car.RentalPrice;
        }

    }
}
