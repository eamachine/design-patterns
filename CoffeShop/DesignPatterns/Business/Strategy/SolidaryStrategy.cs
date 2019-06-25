using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Strategy
{
    public class SolidaryStrategy : DiscountStrategy
    {
        public double Calculate(double subtotal)
        {
            return subtotal - (subtotal * 0.2);
        }
    }
}
