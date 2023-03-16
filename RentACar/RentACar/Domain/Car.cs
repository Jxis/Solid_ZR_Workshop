using RentACar.Interface;

namespace RentACar.Domain
{
    public class Car : IPrintable 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public char BusinessOffer { get; set; }
        public decimal Price { get; set; }
        public decimal RentalPrice { get; set; }


        public string GetPrintableString()
        {
            return $"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}, Base Price: {this.Price}, Rental price: {this.RentalPrice}.\n";
        }
        
    }
}
