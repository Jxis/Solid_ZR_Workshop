using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Interface;

namespace WeatherApplication.Pagination
{
    public class PreviousPageCommand : IPagination
    {
        private readonly WeatherPaginationCommand _paginationCommand;

        public PreviousPageCommand(WeatherPaginationCommand paginationCommand)
        {
            _paginationCommand = paginationCommand;
        }

        public void Execute()
        {
           
            if (_paginationCommand._currentPageIndex > 1)
            {
                _paginationCommand._currentPageIndex--;
                WeatherPaginationCommand prevCommand = new WeatherPaginationCommand(
                    _paginationCommand.weathers,
                    _paginationCommand._pageSize,
                    _paginationCommand._currentPageIndex);

                prevCommand.Execute();

            }
            else
            {
                Console.WriteLine("You are already on the first page.");
            }
        }
    }
}
