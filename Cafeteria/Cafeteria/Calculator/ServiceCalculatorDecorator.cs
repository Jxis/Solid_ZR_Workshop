using Cafeteria.Domain;
using Cafeteria.Enums;
using Cafeteria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Calculator
{
    public class ServiceCalculatorDecorator : PriceCalculatorDecorator
    {
        public ServiceCalculatorDecorator(IPriceCalculator calculator) : base(calculator) { }

        public override decimal CalculatePrice(Coffee coffee)
        {
            decimal basePrice = base.CalculatePrice(coffee);

            if (coffee.ServiceType == ServiceType.CouponCode)
            {
                decimal discountRate = 0.05m;
                decimal discountAmount = coffee.Price * discountRate;
                basePrice -= discountAmount;
            }
            else if (coffee.ServiceType == ServiceType.TakeAway)
            {
                if (coffee.Price <= 7.00m)
                {
                    basePrice *= 1.2m;
                }
            }

            return basePrice;
        }
    }
}
