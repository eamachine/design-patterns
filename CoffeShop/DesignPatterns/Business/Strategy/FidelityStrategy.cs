using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Strategy
{
    public class FidelityStrategy : DiscountStrategy
    {
        public double Calculate(double subtotal)
        {
            double Discount = 0;

            if (subtotal <= 1000)
            {
                Discount = subtotal * 0.1;
            }
            else
            {
                Discount = subtotal * 0.15 < 200 ? subtotal * 0.15 : 200 ;
            }

            return subtotal - Discount;
        }
    }
}
