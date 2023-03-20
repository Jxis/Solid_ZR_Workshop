using WeatherApplication.Strategy;

namespace Weather.Common
{
    public class SortedList
    {
        private List<Weather> list = new List<Weather>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {  
           this.sortStrategy = sortstrategy; 
        }

        public void Add(Weather weather)
        {
            list.Add(weather);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);

        }
    }
}
