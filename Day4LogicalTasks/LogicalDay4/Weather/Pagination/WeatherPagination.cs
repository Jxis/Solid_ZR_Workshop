using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Pagination
{
    public class WeatherPagination
    {
        public readonly List<Weather.Common.Weather> weatherList = new List<Weather.Common.Weather>();
        private readonly int pageSize;
        public int currentPage { get; set; }

        public WeatherPagination(List<Weather.Common.Weather> items, int pageSize)
        {
            weatherList = items;
            this.pageSize = pageSize;
            this.currentPage = 1;
        }

        public List<Weather.Common.Weather> GetCurrentPage()
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = startIndex + pageSize;
            endIndex = Math.Min(endIndex, weatherList.Count);
            List<Weather.Common.Weather> currentWeatherOnPage = weatherList.GetRange(startIndex, endIndex - startIndex);

            foreach (var item in currentWeatherOnPage)
                Console.WriteLine(item.GetPrintableString()); 

            return currentWeatherOnPage;
        }

        public int NextPage()
        {
            if (currentPage < GetTotalPages()) {
                currentPage++;
                return 0; // uspesno
            } else
            {
                Console.WriteLine("There is no next page. This is the last page.");
                return 1; // neuspesno 
            }

                
        }

        public int PreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                return 0; // uspesno
            }
            else {
                Console.WriteLine("This is the first page. There is no previous page.");
                return 1; // neuspesno
            }
        }

        public int GetTotalPages()
        { 
            return (int)Math.Ceiling((double)weatherList.Count / pageSize);
        }
        
    }
}
