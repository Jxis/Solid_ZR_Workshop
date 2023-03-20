using WeatherApplication.Interface;

namespace Weather.Common
{
    public class Weather : IPrintable
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int Temperature { get; set; }
        public decimal WindSpeed { get; set; }

        public Weather(string country, string city, int temperature, decimal windSpeed)
        {
            Country = country;
            City = city;
            Temperature = temperature;
            WindSpeed = windSpeed;
        }

        public string GetPrintableString()
        {
            return $"Country: {this.Country}, City: {this.City}, Temperature: {this.Temperature}, Wind speed: {this.WindSpeed}";
        }
    }
}
