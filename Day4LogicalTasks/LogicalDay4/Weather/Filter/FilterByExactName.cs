﻿namespace WeatherApplication.Filtering
{
    public class FilterByExactName : FilterStrategy
    {
        public override List<Weather.Common.Weather> Filter(List<Weather.Common.Weather> list, string filterBy)
        {
            List<Weather.Common.Weather> returnList = new List<Weather.Common.Weather>();

            foreach (var item in list)
            {
                if (item.Country == filterBy)
                {
                    returnList.Add(item);
                    Console.WriteLine(item.GetPrintableString());
                }
            }


            return returnList;
        }
    }
}
