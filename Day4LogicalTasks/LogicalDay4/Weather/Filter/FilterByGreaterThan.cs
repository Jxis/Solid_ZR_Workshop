using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Filtering
{
    public class FilterByGreaterThan : FilterStrategy
    {
        public override List<Weather.Common.Weather> Filter(List<Weather.Common.Weather> list, string filterBy)
        {
            int temperature = int.Parse(filterBy);
            List<Weather.Common.Weather> returnList = new List<Weather.Common.Weather>();

            foreach (var item in list)
            {
                if (item.Temperature > temperature)
                {
                    returnList.Add(item);
                    Console.WriteLine(item.GetPrintableString());
                }
            }


            return returnList;
        }
    }
}
