namespace WeatherApplication.Strategy
{
    public class SortByCityName : SortStrategy
    {
        public override void Sort(List<Weather.Common.Weather> list)
        {
            List<Weather.Common.Weather> sorted = list.OrderBy(x => x.City).ToList();
            foreach (var item in sorted)
                Console.WriteLine(item.GetPrintableString());
        }
    }
}
