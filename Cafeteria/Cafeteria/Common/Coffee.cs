using Cafeteria.Calculator;
using Cafeteria.Enums;
using Cafeteria.Interface;

namespace Cafeteria.Domain
{
    public class Coffee
    {
        public decimal Price { get; set; }
        public CoffeeSize Size { get; set; }
        public CoffeeType Type { get; set; }
        public List<CoffeeToppings> Toppings { get; set; }
        public ServiceType ServiceType { get; set; }


    }
}
