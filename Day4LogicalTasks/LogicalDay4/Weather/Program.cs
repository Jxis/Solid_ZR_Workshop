// See https://aka.ms/new-console-template for more information
using Weather.Common;
using WeatherApplication.Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<Weather.Common.Weather> weather = new List<Weather.Common.Weather>
        {
            new Weather.Common.Weather("Serbia", "Novi Sad", 8, 2.68m),
            new Weather.Common.Weather("Serbia", "Belgrade", 17, 3.13m),
            new Weather.Common.Weather("Germany", "Munich", 24, 3.6m),
            new Weather.Common.Weather("Sweeden", "Stockholm", 4, 5.81m),
            new Weather.Common.Weather("UK", "London", 2, 1.54m),
            new Weather.Common.Weather("France", "Paris", 27, 2.68m),
            new Weather.Common.Weather("Italy", "Venice", 17, 2.24m),
            new Weather.Common.Weather("Serbia", "Zrenjanin", 9, 0.51m),
            new Weather.Common.Weather("Netherlands", "Amsterdam", 9, 4.12m) 
        };

        SortedList weatherList = new SortedList();

        foreach (var item in weather)
        {
            weatherList.Add(item);
        }

        Console.WriteLine("Sorting by Temperature:");
        weatherList.SetSortStrategy(new SortByTemperatureAscending());
        weatherList.Sort();
        Console.WriteLine("\nSorting by City:");
        weatherList.SetSortStrategy(new SortByCity());
        weatherList.Sort();
        Console.WriteLine("\nSorting by Country:");
        weatherList.SetSortStrategy(new SortByCountry());
        weatherList.Sort();

    }

   
}