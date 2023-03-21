using System.Transactions;
using WeatherApplication.Interface;

namespace Weather.Common
{
    public class Weather : IPrintable
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int Temperature { get; set; }
        public decimal WindSpeed { get; set; }
        public int ZipCode { get; set; }

        public Weather(string country,int zipCode, string city, int temperature, decimal windSpeed)
        {
            Country = country;
            City = city;
            Temperature = temperature;
            WindSpeed = windSpeed;
            ZipCode = zipCode;
        }

        public string GetPrintableString()
        {
            return $"Country: {this.Country},Zip code: {this.ZipCode} City: {this.City}, Temperature: {this.Temperature}, Wind speed: {this.WindSpeed}";
        }
    }
}
