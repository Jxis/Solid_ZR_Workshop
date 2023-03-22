using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Filtering;

namespace WeatherApplication.Common
{
    public class FilteredList
    {
        public List<Weather.Common.Weather> list = new List<Weather.Common.Weather>();
        private FilterStrategy filterStrategy;
        private string filterBy;

        public void SetFilterStrategy(FilterStrategy filter)
        {
            this.filterStrategy = filter;
        }

        public void Add(Weather.Common.Weather weather)
        {
            list.Add(weather);
        }
        public void AddFilterWord(string word)
        {
            filterBy = word;
        }
            
        public List<Weather.Common.Weather> Filter() 
        { 
            List<Weather.Common.Weather> filteredList = new List<Weather.Common.Weather>();
            filteredList = filterStrategy.Filter(list,filterBy);
            return filteredList;
        
        }
    }
}
