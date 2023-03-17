using Cafeteria.Domain;
using Cafeteria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Calculator
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal CalculatePrice(Coffee coffee)
        {
            return coffee.Price;
        }
    }
}
