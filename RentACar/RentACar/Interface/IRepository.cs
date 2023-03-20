using RentACar.Domain;

namespace RentACar.Interface
{
    public interface IRepository<in T> where T : Car
    {
        void Add(T entity);
        List<Car> GetAll();
        void Delete(T entity);
        List<Car> GetByModel(string Model);
        List<Car> GetByBusinessOffer(char offer);
    }
}
