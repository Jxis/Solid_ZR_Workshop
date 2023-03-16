using RentACar.Interface;

namespace RentACar.Domain.Payment
{
    public class CashPayment : IPaymentMethod
    {
        public string Pay(Car car)
        {
            return ($"Paid {car.RentalPrice} with cash for {car.Make}.");
        }
    }
}
