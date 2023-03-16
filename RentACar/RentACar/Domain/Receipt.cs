using RentACar.Interface;

namespace RentACar.Domain
{
    public class Receipt : IReceipt
    {
        public Receipt() { }
        public string SendEmail(Car car)
        {        
            return $"Sending email for car: {car.Make}";
            
        }
    }
}
