using Cafeteria.Calculator;
using Cafeteria.Interface;

namespace Cafeteria.Domain
{
    public class Receipt 
    {
   
        public void PrintReceipt(Coffee coffee)
        {
            Console.WriteLine("        Receipt       ");
            Console.WriteLine("----------------------");
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            Console.WriteLine("----------------------");
            Console.WriteLine("Type: " + coffee.Type);
            Console.WriteLine("Size: " + coffee.Size);
            Console.WriteLine("Toppings :");
            foreach (var item in coffee.Toppings)
            {
                Console.WriteLine("         " + item);
            }
            Console.WriteLine("Service: " + coffee.ServiceType);
            Console.WriteLine("----------------------");

            IPriceCalculator calculator = new TypeCalculatorDecorator(null);
            calculator = new SizeCalculatorDecorator(calculator);
            calculator = new ToppingsCalculatorDecorator(calculator);
            calculator = new ServiceCalculatorDecorator(calculator);

            IPriceCalculator priceCalculator = new PriceCalculator();
            IPriceCalculator priceCalculatorDecorator = new PriceCalculatorDecorator(priceCalculator);
            IPriceCalculator typeCalculator = new TypeCalculatorDecorator(priceCalculatorDecorator);
            IPriceCalculator sizeCalc = new SizeCalculatorDecorator(typeCalculator);
            IPriceCalculator toppingsCalculator = new ToppingsCalculatorDecorator(sizeCalc);
            IPriceCalculator serviceCaluclator = new ServiceCalculatorDecorator(toppingsCalculator);

            decimal finalPrice = serviceCaluclator.CalculatePrice(coffee);


            Console.WriteLine("TOTAL: " + finalPrice + " Euros");
            Console.WriteLine("----------------------");
            Console.WriteLine("THANK YOU FOR VISITING!");
        }



    }
}
