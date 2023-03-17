using Cafeteria.Calculator;
using Cafeteria.Enums;
using Cafeteria.Interface;

namespace Cafeteria.Domain
{
    public class Order : IOrder
    {
        public double totalPrice { get; set; }
        public void OrderCoffee()
        {
            Coffee coffee = new Coffee();

            #region Type
            bool first = false;
            while (first == false)
            {
                Console.WriteLine("Choose your coffee type:");
                Console.WriteLine("1. Espresso");
                Console.WriteLine("2. Cappuccino");
                Console.WriteLine("3. Lattee Macchiato");

                string AnswerForType = Console.ReadLine();
                int AnswerType = int.Parse(AnswerForType);
                

                switch (AnswerType)
                {
                    case 1:
                        coffee.Type = CoffeeType.Espresso;
                        first = true;
                        break;
                    case 2:
                        coffee.Type = CoffeeType.Cappuccino;
                        first = true;
                        break;
                    case 3:
                        coffee.Type = CoffeeType.LatteMacchiato;
                        first = true;
                        break;
                    default:
                        Console.WriteLine("You didn't choose the correct number.Try again.");
                        first = false;
                        break;
                }

            }
            #endregion

            #region Size
            bool second = false;
            while (second == false)
            {
                Console.WriteLine("\nChoose your coffee size:");
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Large");

                string AnswerForSize = Console.ReadLine();
                int AnswerSize = int.Parse(AnswerForSize);
                switch (AnswerSize)
                {
                    case 1:
                        coffee.Size = CoffeeSize.Regular;
                        second = true;
                        break;
                    case 2:
                        coffee.Size = CoffeeSize.Large;
                        second = true;
                        break;
                    default:
                        Console.WriteLine("You didn't choose the correct number.Try again.");
                        second = false;
                        break;

                }

            }
            #endregion

            #region Toppings
            bool over = true;
            List<CoffeeToppings> toppings = new List<CoffeeToppings>();
            coffee.Toppings = toppings;

            while (over)
            {
                Console.WriteLine("\nWould you like any toppings?");
                Console.WriteLine("1. Milk");
                Console.WriteLine("2. Cinnamon");
                Console.WriteLine("3. Brown Sugar");
                Console.WriteLine("4. That's it");

                string AnswerForToppings = Console.ReadLine();
                int AnswerToppings = int.Parse(AnswerForToppings);


                switch (AnswerToppings)
                {
                    case 1:
                        toppings.Add(CoffeeToppings.Milk);
                        break;
                    case 2:
                        toppings.Add(CoffeeToppings.Cinnamon);
                        break;
                    case 3:
                        toppings.Add(CoffeeToppings.BrownSugar);
                        break;
                    case 4:
                        over = false;
                        break;
                    default:
                        Console.WriteLine("You didn't choose the correct number.Try again.");
                        break;
                }

            }
            #endregion

            #region Service

            bool third = false;
            while (third == false)
            {
                Console.WriteLine("\nHow would you like to be served?");
                Console.WriteLine("1. In-House");
                Console.WriteLine("2. Coupon Code");
                Console.WriteLine("3. Take Away");

                string AnswerForService = Console.ReadLine();
                int AnswerService = int.Parse(AnswerForService);

                switch (AnswerService)
                {
                    case 1:
                        coffee.ServiceType = ServiceType.InHouse;
                        third = true;
                        break;
                    case 2:
                        coffee.ServiceType = ServiceType.CouponCode;
                        third = true;
                        break;
                    case 3:
                        coffee.ServiceType = ServiceType.TakeAway;
                        third = true;
                        break;
                    default:
                        Console.WriteLine("You didn't choose the correct number.Try again.");
                        break;

                }

            }
            #endregion

            Console.WriteLine("\n\n");
        
            Receipt receipt = new Receipt();
            receipt.PrintReceipt(coffee);
        }
        
    }
}
