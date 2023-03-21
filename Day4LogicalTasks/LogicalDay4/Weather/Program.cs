// See https://aka.ms/new-console-template for more information
using Weather.Common;
using WeatherApplication.Common;
using WeatherApplication.SearchStrategy;
using WeatherApplication.Sort;
using WeatherApplication.Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<Weather.Common.Weather> weather = new List<Weather.Common.Weather>
        {
            new Weather.Common.Weather("Serbia",21000, "Novi Sad", 8, 2.68m),
            new Weather.Common.Weather("Serbia",11000, "Belgrade", 17, 3.13m),
            new Weather.Common.Weather("Germany",80335, "Munich", 24, 3.6m),
            new Weather.Common.Weather("Sweeden",10316, "Stockholm", 4, 5.81m),
            new Weather.Common.Weather("UK",56273, "London", 2, 1.54m),
            new Weather.Common.Weather("France",70213, "Paris", 27, 2.68m),
            new Weather.Common.Weather("Italy",30100, "Venice", 17, 2.24m),
            new Weather.Common.Weather("Serbia",23000, "Zrenjanin", 9, 0.51m),
            new Weather.Common.Weather("Netherlands",10110, "Amsterdam", 9, 4.12m) 
        };

        SortedList weatherList = new SortedList();
        
        foreach (var item in weather)
        {
            weatherList.Add(item);
        }
        #region Sorting
        ////Console.WriteLine("Sorting by Temperature:");
        ////weatherList.SetSortStrategy(new SortByTemperatureAscending());
        ////weatherList.Sort();
        ////Console.WriteLine("\nSorting by City:");
        ////weatherList.SetSortStrategy(new SortByCity());
        ////weatherList.Sort();
        ////Console.WriteLine("\nSorting by Country:");
        ////weatherList.SetSortStrategy(new SortByCountry());
        ////weatherList.Sort();
        ////Console.WriteLine("\nSorting by Wind Speed:");
        ////weatherList.SetSortStrategy(new SortByWindSpeed());
        ////weatherList.Sort();
        #endregion

        #region Search
        // For binary search we need to first sort the list by zip code
        List<Weather.Common.Weather> sortedByZipCode = new List<Weather.Common.Weather>();
        weatherList.SetSortStrategy(new SortByZipCode());
        sortedByZipCode = weatherList.Sort();

        Console.WriteLine("Type the zip code:");
        string answer = Console.ReadLine();

        SearchedList searchedList = new SearchedList();
        
        foreach(var item in sortedByZipCode)
        {
            searchedList.Add(item);
        }
        searchedList.AddSearcedWord(answer);

        searchedList.SetSearchStrategy(new SearchByZipCode());
        searchedList.Search();

        #endregion

    }


}