namespace WeatherApplication.Filtering
{
    public abstract class FilterStrategy
    {
        public abstract List<Weather.Common.Weather> Filter(List<Weather.Common.Weather> list, string filterBy);
    }
}
