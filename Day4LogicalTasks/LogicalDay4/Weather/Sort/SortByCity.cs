namespace WeatherApplication.Strategy
{
    public class SortByCity : SortStrategy
    {
        public override List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list)
        {
            // USING LINQ
            //List<Weather.Common.Weather> sorted = list.OrderBy(x => x.City).ToList();
            //foreach (var item in sorted)
            //    Console.WriteLine(item.GetPrintableString());

            // USING BUBBLE SORT
            int n = list.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    //Ako su jednaki vraca 0
                    if (string.Compare(list[i - 1].City, list[i].City) > 0)
                    {
                        //Weather.Common.Weather temp = list[i - 1];
                        //list[i - 1] = list[i];
                        //list[i] = temp;

                        (list[i], list[i - 1]) = (list[i - 1], list[i]);
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
