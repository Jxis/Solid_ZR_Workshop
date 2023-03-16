// See https://aka.ms/new-console-template for more information

using RentACar.Domain;
using RentACar.Domain.BusinessOffer;
using RentACar.Domain.Payment;

List<Car> cars = new List<Car>();

#region Cars
Car car1 = new Car();
cars.Add(car1);
car1.Make = "Toyota";
car1.Model = "Model 1";
car1.Year = "1999";
car1.BusinessOffer = 'S';
car1.Price = 10000;

Car car2 = new Car();
cars.Add(car2);
car2.Make = "BMW";
car2.Model = "Model 2";
car2.Year = "2000";
car2.BusinessOffer = 'P';
car2.Price = 50000;

Car car3 = new Car();
cars.Add(car3);
car3.Make = "Hyundai";
car3.Model = "Model 3";
car3.Year = "2010";
car3.BusinessOffer = 'P';
car3.Price = 2000;
#endregion

#region First and Second
Console.WriteLine("First and second task:");
List<Car> rentalCars = cars.Where(c => c.BusinessOffer == 'S').ToList();
Console.WriteLine("----- STANDARD CARS -----\n");
foreach (var car in rentalCars)
{
    BusinessOffer bo = new BusinessOffer(car);
    car.RentalPrice = bo.CalculateRentalPrice();
    Console.WriteLine(car.GetPrintableString());
}
Console.WriteLine("-------------------------\n");

Console.WriteLine("----- PREMIUM CARS -----\n");
List<Car> premiumCars = cars.Where(c => c.BusinessOffer == 'P').ToList();
foreach(var car in premiumCars)
{
    BusinessOffer bo = new BusinessOffer(car);
    car.RentalPrice = bo.CalculateRentalPrice();
    Console.WriteLine(car.GetPrintableString());
    
}
Console.WriteLine("-----------------------");
#endregion

#region Third
Console.WriteLine("\nThird task:");
Console.WriteLine("Requesting receipt for car 2");
Receipt receipt = new Receipt();
Console.WriteLine(receipt.SendEmail(car2));
#endregion

#region Fourth
Console.WriteLine("\nFourth task:");
Payment payment1 = new Payment(car1, "Cash");
Console.WriteLine(payment1.PayTheVehicle());
Payment payment2 = new Payment(car2, "CreditCard");
Console.WriteLine(payment2.PayTheVehicle());
#endregion


