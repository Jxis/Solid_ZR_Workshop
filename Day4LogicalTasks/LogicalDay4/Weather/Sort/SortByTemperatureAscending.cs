namespace WeatherApplication.Strategy
{
    public class SortByTemperatureAscending : SortStrategy
    {
        public List<int> Temperatures = new List<int>();
        public override List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list)
        {
            // USING LINQ
            //List<Weather.Common.Weather> sorted = list.OrderBy(x => x.Temperature).ToList();
            //foreach(var item in sorted)
            //    Console.WriteLine(item.GetPrintableString());

            // USING BUBBLE SORT        
            int n = list.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (list[i - 1].Temperature > list[i].Temperature)
                    {
                        Weather.Common.Weather temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            foreach (var item in list)
                Console.WriteLine(item.GetPrintableString());

            return list;
        }
     
    }
}
