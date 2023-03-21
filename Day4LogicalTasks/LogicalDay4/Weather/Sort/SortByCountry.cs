using System.Reflection;

namespace WeatherApplication.Strategy
{
    public class SortByCountry : SortStrategy
    {
        //MERGE SORT
        public override List<Weather.Common.Weather> Sort(List<Weather.Common.Weather> list)
        {
            MergeSortByCountry(list, 0, list.Count - 1);
            foreach (var item in list)
                Console.WriteLine(item.GetPrintableString());

            return list;
        }

        public void MergeSortByCountry(List<Weather.Common.Weather> list, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; 
                //za svaki niz radi sort
                MergeSortByCountry(list, left, mid);
                MergeSortByCountry(list, mid + 1, right);

                // opet pozove kako bi proverio da li je dosao do kraja 
                MergeByCountry(list, left, mid, right);
                
            }
        }

        public void MergeByCountry(List<Weather.Common.Weather> list, int left, int mid, int right)
        {
            int leftLength = mid - left + 1;
            int rightLength = right - mid;

            List<Weather.Common.Weather> leftList = new List<Weather.Common.Weather>();
            List<Weather.Common.Weather> rightList = new List<Weather.Common.Weather>();

            // Dodaje elemente u liste 
            for (int i = 0; i < leftLength; i++)
            {
                leftList.Add(list[left + i]);
            }

            for (int j = 0; j < rightLength; j++)
            {
                rightList.Add(list[mid + j + 1]);
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int k = left; // u ovom slucaju 0 

            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (leftList[leftIndex].Country.CompareTo(rightList[rightIndex].Country) <= 0)
                {
                    list[k] = leftList[leftIndex];
                    leftIndex++;
                }
                else
                {
                    list[k] = rightList[rightIndex];
                    rightIndex++;
                }

                k++; // predje na sledeci element u listi 
            }
            
            // ako levi ili desni zavrsi ranije, gleda ove whilove 
            while (leftIndex < leftLength)
            {
                list[k] = leftList[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < rightLength)
            {
                list[k] = rightList[rightIndex];
                rightIndex++;
                k++;
            }
        }
    }

        
}

