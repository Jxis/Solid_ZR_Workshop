using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.SearchStrategy
{
    public class SearchByZipCode : SearchStrategy
    {
        public override void Search(List<Weather.Common.Weather> list, string searchingBy)
        {
            int zipCode = int.Parse(searchingBy);
            // LINEAR SEARCH
            //foreach (var weather in list)
            //{
            //    if (weather.ZipCode == zipCode)
            //    {
            //        Console.WriteLine(weather.GetPrintableString());
            //    }
            //}
            // BINARY SEARCH
            List<Weather.Common.Weather> weatherFound = new List<Weather.Common.Weather>();
            weatherFound = BinarySearch(list, zipCode, 0, list.Count());
            foreach (var item in weatherFound)
                Console.WriteLine(item.GetPrintableString());

            if (weatherFound.Count == 0)
                Console.WriteLine("We couldn't find any city with that zip code.");
        }

        public List<Weather.Common.Weather> BinarySearch(List<Weather.Common.Weather> list, int searchingBy, int left, int right)
        {
            List<Weather.Common.Weather> weatherFound = new List<Weather.Common.Weather>();
            if (left <= right)
            {
                int middle = (left + right) / 2;

                if (list[middle].ZipCode == searchingBy)
                {
                    weatherFound.Add(list[middle]);
                    return weatherFound;
                }

                if (list[middle].ZipCode > searchingBy)
                {
                    return BinarySearch(list, searchingBy, left, middle - 1);
                }
                else {
                    return BinarySearch(list, searchingBy, middle + 1, right);
                }
            }
            return weatherFound; // ne mozemo da nadjemo zipcode, ne postoji, vraca praznu listu
        }
    }
}
