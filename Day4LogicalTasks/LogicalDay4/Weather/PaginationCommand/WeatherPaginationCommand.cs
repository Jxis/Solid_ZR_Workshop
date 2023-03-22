using WeatherApplication.Interface;

namespace WeatherApplication.Pagination
{
    public class WeatherPaginationCommand : IPagination
    {
        public  List<Weather.Common.Weather> weathers;
        public  int _pageSize;
        public int _currentPageIndex { get; set; }

        public WeatherPaginationCommand(List<Weather.Common.Weather> weathers, int pageSize, int currentPageIndex)
        {
            this.weathers = weathers;
            _pageSize = pageSize;
            _currentPageIndex = currentPageIndex;
        }

        public void Execute()
        {
            Console.WriteLine($"============ Current page: {_currentPageIndex} ================");
            int startIndex = (_currentPageIndex - 1) * _pageSize;
            int endIndex = startIndex + _pageSize;
            endIndex = Math.Min(endIndex, weathers.Count);
            List<Weather.Common.Weather> currentWeatherOnPage = weathers.GetRange(startIndex, endIndex - startIndex);

            foreach (var item in currentWeatherOnPage)
                Console.WriteLine(item.GetPrintableString());
            Console.WriteLine($"=============================================");
        }

        public int GetTotalPages()
        {
            return (int)Math.Ceiling((double)weathers.Count / _pageSize);
        }
    }
}
