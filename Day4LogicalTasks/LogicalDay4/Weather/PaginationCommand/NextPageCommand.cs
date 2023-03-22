using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication.Interface;

namespace WeatherApplication.Pagination
{
    public class NextPageCommand : IPagination
    {
        private readonly WeatherPaginationCommand _paginationCommand;

        public NextPageCommand(WeatherPaginationCommand paginationCommand)
        {
            _paginationCommand = paginationCommand;
        }

        public void Execute()
        {
            
            if (_paginationCommand._currentPageIndex < _paginationCommand.GetTotalPages())
            {
                _paginationCommand._currentPageIndex++;
                WeatherPaginationCommand nextCommand = new WeatherPaginationCommand(
                   _paginationCommand.weathers,
                   _paginationCommand._pageSize,
                   _paginationCommand._currentPageIndex);

                nextCommand.Execute();
            }
            else
            {
                Console.WriteLine("You are already on the last page.");
            }
        }
    }
    
}
