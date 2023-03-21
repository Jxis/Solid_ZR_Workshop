using WeatherApplication.Strategy;

namespace WeatherApplication.Sort
{
    public class SortByZipCode : SortStrategy
    {
        public override List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list)
        {
            int n = list.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (list[i - 1].ZipCode > list[i].ZipCode)
                    {
                        Weather.Common.Weather temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            return list;
        }
    }
}
