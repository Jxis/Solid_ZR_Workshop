using RentACar.Interface;

namespace RentACar.Domain.Payment
{
    public class Payment
    {
        public Car car = new Car();
        public string PaymentType { get; set; }

        public Payment(Car car, string paymentType)
        {
            this.car = car;
            PaymentType = paymentType;
        }

        public IPaymentMethod GetPayment()
        {
            if (PaymentType == "Cash")
            {
                return new CashPayment();
            }
            else if (PaymentType == "CreditCard")
            {
                return new CreditCardPayment();
            }
            else
            {
                throw new ArgumentException($"Invalid business offer type: {PaymentType}");
            }
        }
        public string PayTheVehicle()
        {
            IPaymentMethod payment = GetPayment();
            string answer = payment.Pay(car);

            return answer;

        }
    }
}
