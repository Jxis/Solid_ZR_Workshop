using WeatherApplication.Interface;
using WeatherApplication.Pagination;

namespace WeatherApplication.PaginationCommand
{
    public class CurrentPageCommand : IPagination
    {
        private readonly WeatherPaginationCommand _paginationCommand;

        public CurrentPageCommand(WeatherPaginationCommand paginationCommand)
        {
            _paginationCommand = paginationCommand;
        }

        public void Execute()
        {
            _paginationCommand.Execute();
        }
    }
}
