namespace WeatherApplication.Common
{
    public class SearchedList
    {
        private List<Weather.Common.Weather> list = new List<Weather.Common.Weather>();
        private SearchStrategy.SearchStrategy searchStratery;
        private string searchBy;

        public void SetSearchStrategy(SearchStrategy.SearchStrategy searchStrategy)
        { 
            this.searchStratery = searchStrategy;
        }

        public void Add(Weather.Common.Weather weather)
        {
            list.Add(weather);;
        }

        public void AddSearcedWord(string word)
        { 
            searchBy = word;
        }

        public void Search()
        {
            searchStratery.Search(list,searchBy);
        }
            

    }
}
