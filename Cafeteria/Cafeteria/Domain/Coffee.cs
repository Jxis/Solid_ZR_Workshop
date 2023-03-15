namespace Cafeteria.Domain
{
    public class Coffee
    {
        public double Price { get; set; }
        public CoffeeSize Size { get;set; }
        public CoffeeType Type { get; set; }
        public List<CoffeeToppings> Toppings  { get; set; }
        public ServiceType serviceType { get; set; }
        public Coffee() { }

        public double CalculatePrice()
        {
            PriceCalculator calculator = new PriceCalculator(this);
            
            return calculator.FinalPrice;
        }


    }
}
