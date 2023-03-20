namespace WeatherApplication.Strategy
{
    public class SortByTemperatureAscending : SortStrategy
    {
        public override void Sort(List<Weather.Common.Weather> list)
        {
            List<Weather.Common.Weather> sorted = list.OrderBy(x => x.Temperature).ToList();
            foreach(var item in sorted)
                Console.WriteLine(item.GetPrintableString());
        }
    }
}
