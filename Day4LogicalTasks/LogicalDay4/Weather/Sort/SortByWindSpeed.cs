using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Strategy
{
    public class SortByWindSpeed : SortStrategy
    {
        // QUICK SORT
        public override List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list)
        {
            QuickSort(list, 0, list.Count - 1);
            foreach (var item in list)
                Console.WriteLine(item.GetPrintableString());

            return list;
        }

        public void QuickSort(List<Weather.Common.Weather> list, int left, int right)
        {
            // proverava da li je dosao do kraja 
            if (left < right)
            {
                int pivot = Partition(list, left, right);
                QuickSort(list, left, pivot - 1);
                QuickSort(list, pivot + 1, right);
            }
        }

        public int Partition(List<Weather.Common.Weather> list, int left, int right)
        {
            decimal pivot = list[right].WindSpeed;
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (list[j].WindSpeed <= pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }
            Swap(list, i + 1, right); // na kraju zameni pivota 
            return i + 1; // vrati onog koji treba sledeci pivot da bude 
        }

        public void Swap(List<Weather.Common.Weather> list, int i, int j)
        { 
            Weather.Common.Weather temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
