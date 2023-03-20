using RentACar.Domain;
using RentACar.Interface;

namespace RentACar.Repository
{
    public class CarRepository : IRepository<Car>
    {
        public List<Car> cars = new List<Car>();

        public void Add(Car entity)
        {
            cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            List<Car> cars = GetAll();
            foreach (Car car in cars)
            {
                if (car == entity)
                {
                    cars.Remove(car);
                }
            }
            
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetByBusinessOffer(char offer)
        {
            List<Car> allCars = GetAll();
            List<Car> carsOffer = new List<Car>();

            foreach (var item in allCars)
            { 
                if(item.BusinessOffer == offer)
                    carsOffer.Add(item);
            }

            return carsOffer;
        }

        public List<Car> GetByModel(string Model)
        {
            List<Car> allCars = GetAll();
            List<Car> answer = new List<Car>();
            foreach (var item in allCars)
            {
                if (item.Model == Model)
                {
                    answer.Add(item);
                    item.GetPrintableString();
                }
            }

            return answer;
        }
    }
}
