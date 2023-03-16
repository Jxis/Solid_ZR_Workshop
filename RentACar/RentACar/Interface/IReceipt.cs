using RentACar.Domain;

namespace RentACar.Interface
{
    public interface IReceipt
    {
        public string SendEmail(Car car);
    }
}
