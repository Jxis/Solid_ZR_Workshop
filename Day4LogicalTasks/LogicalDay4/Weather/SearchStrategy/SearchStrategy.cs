namespace WeatherApplication.SearchStrategy
{
    public abstract class SearchStrategy
    {
        public abstract void Search(List<Weather.Common.Weather> list, string searchingBy);
    }
}
