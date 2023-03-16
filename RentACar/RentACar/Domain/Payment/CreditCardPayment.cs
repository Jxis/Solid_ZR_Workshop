using RentACar.Interface;

namespace RentACar.Domain.Payment
{
    public class CreditCardPayment : IPaymentMethod
    {
        Receipt receipt = new Receipt();
        public string Pay(Car car)
        {
            receipt.SendEmail(car);
            Console.WriteLine("\n");
            Console.WriteLine( receipt.SendEmail(car));

            return ($"Paid {car.RentalPrice} with credit card for {car.Make}.");
            
        }
    }
}
