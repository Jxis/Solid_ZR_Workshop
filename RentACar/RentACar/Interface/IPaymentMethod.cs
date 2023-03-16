using RentACar.Domain;

namespace RentACar.Interface
{
    public interface IPaymentMethod
    {
        public string Pay(Car car);
    }
}
