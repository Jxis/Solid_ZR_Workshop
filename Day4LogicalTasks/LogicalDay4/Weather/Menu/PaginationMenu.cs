using WeatherApplication.Pagination;

namespace WeatherApplication.Menu
{
    public class PaginationMenu
    {
        public PaginationMenu(List<Weather.Common.Weather> weather)
        {

            Console.WriteLine("Choose how many weather per page do you want:");
            string answerForPages = Console.ReadLine();
            int answerForPagesInt = int.Parse(answerForPages);
            if (answerForPagesInt > 0 && answerForPagesInt <= weather.Count())
            {
                WeatherPagination pagination = new WeatherPagination(weather, answerForPagesInt);
                Console.WriteLine("Current page content:");
                List<Weather.Common.Weather> currectWeather = pagination.GetCurrentPage();
                int totalPages = pagination.GetTotalPages();
                //Console.WriteLine($"Total pages: {totalPages}");


                Console.WriteLine($"\nPAGE NUMBER: {pagination.currentPage}");
                while (true)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Go to next page");
                    Console.WriteLine("2. Go to previous page");
                    Console.WriteLine("3. Go to first page");
                    Console.WriteLine("4. Go to last page");
                    string answer = Console.ReadLine();
                    int answerForOption = int.Parse(answer);

                    switch (answerForOption)
                    {
                        case 1:

                            int numNext = pagination.NextPage();
                            if (numNext == 0)
                            {
                                pagination.GetCurrentPage();
                                Console.WriteLine($"\nPAGE NUMBER: {pagination.currentPage}");
                            }
                            break;
                        case 2:
                            int numPrev = pagination.PreviousPage();
                            if (numPrev == 0)
                            {
                                pagination.GetCurrentPage();
                                Console.WriteLine($"\nPAGE NUMBER: {pagination.currentPage}");
                            }

                            break;
                        case 3:
                            pagination.currentPage = 1;
                            pagination.GetCurrentPage();
                            break;

                        case 4:
                            pagination.currentPage = totalPages;
                            pagination.GetCurrentPage();
                            break;
                        default:
                            break;
                    }
                }

            }
        }
    }
}

