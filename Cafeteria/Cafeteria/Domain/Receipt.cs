namespace Cafeteria.Domain
{
    public class Receipt
    {
        public Receipt() { }

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
            Console.WriteLine("Service: " + coffee.serviceType);
            Console.WriteLine("----------------------");
            double price = coffee.CalculatePrice();
            Console.WriteLine("TOTAL: " + price + " Euros");
            Console.WriteLine("----------------------");
            Console.WriteLine("THANK YOU FOR VISITING!");

        }
    }
}
