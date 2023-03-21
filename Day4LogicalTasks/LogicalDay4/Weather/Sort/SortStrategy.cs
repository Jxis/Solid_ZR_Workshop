namespace WeatherApplication.Strategy
{
    public abstract class SortStrategy 
    {
        public abstract List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list);

    }
}
