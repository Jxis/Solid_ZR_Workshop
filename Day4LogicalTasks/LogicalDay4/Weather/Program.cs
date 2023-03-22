// See https://aka.ms/new-console-template for more information
using Weather.Common;
using WeatherApplication.Common;
using WeatherApplication.Filtering;
using WeatherApplication.Pagination;

public class Program
{
    public static void Main(string[] args)
    {
        List<Weather.Common.Weather> weather = new List<Weather.Common.Weather>
        {
               new Weather.Common.Weather("Serbia",21000, "Novi Sad", 8, 2.68m),
                new Weather.Common.Weather("Serbia",11000, "Belgrade", 17, 3.13m),
                new Weather.Common.Weather("Germany",80335, "Munich", 24, 3.6m),
                new Weather.Common.Weather("Sweeden",10316, "Stockholm", 4, 5.81m),
                new Weather.Common.Weather("UK",56273, "London", 2, 1.54m),
                new Weather.Common.Weather("France",70213, "Paris", 27, 2.68m),
                new Weather.Common.Weather("Italy",30100, "Venice", 17, 2.24m),
                new Weather.Common.Weather("Serbia",23000, "Zrenjanin", 9, 0.51m),
                new Weather.Common.Weather("Netherlands",10110, "Amsterdam", 9, 4.12m),
                new Weather.Common.Weather("Serbia", 24430, "Ada", 9, 5.81m),
                new Weather.Common.Weather("Serbia",18000, "Nis", 10, 8.9m ),
                new Weather.Common.Weather("Serbia", 23218, "Nova Crnja", 9, 4.92m),
                new Weather.Common.Weather("Serbia", 21300,"Beocin", 17, 3.21m),
                new Weather.Common.Weather("Serbia", 25250, "Odzaci", 3, 8.2m),
                new Weather.Common.Weather("Serbia", 11500, "Obrenovac", 12, 5m),
                new Weather.Common.Weather("Serbia", 19210, "Bor", 7, 7.7m),
                new Weather.Common.Weather("Serbia", 26000, "Pancevo", 6, 6.6m)
        };

        #region old
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
        //For binary search we need to first sort the list by zip code
        //List<Weather.Common.Weather> sortedByZipCode = new List<Weather.Common.Weather>();
        //weatherList.SetSortStrategy(new SortByZipCode());
        //sortedByZipCode = weatherList.Sort();

        //Console.WriteLine("Type the zip code:");
        //string answer = Console.ReadLine();

        //SearchedList searchedList = new SearchedList();

        //foreach (var item in sortedByZipCode)
        //{
        //    searchedList.Add(item);
        //}
        //searchedList.AddSearcedWord(answer);

        //searchedList.SetSearchStrategy(new SearchByZipCode());
        //searchedList.Search();

        #endregion

        #endregion

        FilteredList filteredList = new FilteredList();
        foreach (var item in weather)
        {
            filteredList.Add(item);
        }

        Console.WriteLine("Do you want to filter data or not?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");

        string answerForFiltrationOrNo = Console.ReadLine();
        int answerForFiltrationInt = int.Parse(answerForFiltrationOrNo);

        switch (answerForFiltrationInt)
        {
            case 1:
                Console.WriteLine("Do you want to filter by temperature or by country?");
                string answerForChoise = Console.ReadLine();
                int answerForChoiseInt = int.Parse(answerForChoise);

                switch (answerForChoiseInt)
                {
                    case 1:
                        Console.WriteLine("Choose temperature:");
                        string answerForTemperature = Console.ReadLine();
                        Console.WriteLine("Choose filter:");
                        Console.WriteLine("1.Exact equal");
                        Console.WriteLine("2.Greater than");
                        Console.WriteLine("3.Less than ");
                        string answerForFilter = Console.ReadLine();

                        int answerForFilterInt = int.Parse(answerForFilter);

                        
                        filteredList.AddFilterWord(answerForTemperature);

                        switch (answerForFilterInt)
                        {
                            case 1:
                                filteredList.SetFilterStrategy(new FilterByExactEqual());
                                List<Weather.Common.Weather> newList = filteredList.Filter();
                                Pagination paginationForTemperature = new Pagination(newList);
                                break;
                            case 2:
                                filteredList.SetFilterStrategy(new FilterByGreaterThan());
                                List<Weather.Common.Weather> newList1 = filteredList.Filter();
                                Pagination paginationForTemperature2 = new Pagination(newList1);
                                break;
                            case 3:
                                filteredList.SetFilterStrategy(new FilterByLessThan());
                                List<Weather.Common.Weather> newList2 = filteredList.Filter();
                                Pagination paginationForTemperature4 = new Pagination(newList2);
                                break;
                            default:
                                Console.WriteLine("You didn't choose the correct number.");
                                break;
                        }

                        
                        break;

                    case 2:
                        Console.WriteLine("Choose country:");
                        string answerForCountry = Console.ReadLine();
                        Console.WriteLine("Choose filter:");
                        Console.WriteLine("1.Exact name");
                        Console.WriteLine("2.Starts with");
                        string answerForFilterCountry = Console.ReadLine();

                        int answerForFilterCountryInt = int.Parse(answerForFilterCountry);

                        filteredList.AddFilterWord(answerForCountry);

                        switch (answerForFilterCountryInt)
                        {
                            case 1:
                                filteredList.SetFilterStrategy(new FilterByExactName());
                                List<Weather.Common.Weather>  List9 = filteredList.Filter();
                                Pagination paginationForCountry1 = new Pagination(List9);
                                break;
                            case 2:
                                filteredList.SetFilterStrategy(new FilterByStartsWith());
                                List<Weather.Common.Weather> list10 = filteredList.Filter();
                                Pagination paginationForCountry2 = new Pagination(list10);
                                break;

                            default:
                                Console.WriteLine("You didn't choose the correct number.");
                                break;
                        }

                        break;

                    default:
                        break;
                }

                break;
            case 2:
                Pagination pagination = new Pagination(weather);
                break;
            default:
                break;
        }

    }

}


